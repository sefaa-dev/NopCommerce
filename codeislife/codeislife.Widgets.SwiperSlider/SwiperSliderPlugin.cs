using Nop.Services.Localization;
using Nop.Services.Plugins;

namespace codeislife.Widgets.SwiperSlider
{
    public class SwiperSliderPlugin : BasePlugin
    {
        #region Fields
        private readonly ILocalizationService _localizationService;
        #endregion

        #region Ctor
        public SwiperSliderPlugin(ILocalizationService localizationService)
        {
            _localizationService = localizationService;

        }
        #endregion

        #region Methods
        public override void Install()
        {
            _localizationService.AddOrUpdatePluginLocaleResource("codeislife.Widgets.SwiperSlider.test", "test");
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }

        public override void PreparePluginToUninstall()
        {
            _localizationService.DeletePluginLocaleResources("codeislife.Widgets.SwiperSlider");
        }

        //public override string GetConfigurationPageUrl()
        //{
        //    return base.GetConfigurationPageUrl();
        //}
        #endregion



    }
}
