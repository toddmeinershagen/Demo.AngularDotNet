using System.Web.Optimization;

namespace Demo.Budgeting.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap")
                .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.min.js")
                .IncludeDirectory("~/app", "*.js")
                );
        }
    }
}