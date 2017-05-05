/// <summary>
///
///   ___Made by Zakir Shikhli___
///   
/// https://www.facebook.com/DarkAndLightDevelopmentStudio
/// https://www.facebook.com/zakirshikhli
/// 
/// ____Free for use and share____
/// 
/// </summary>


void Awake()
{
#if UNITY_EDITOR || UNITY_STANDALONE

        //Correct Portrait resolution for Standalone Build
        Screen.SetResolution(       
         Screen.resolutions[Screen.resolutions.Length - 1].height*9/16,
         Screen.resolutions[Screen.resolutions.Length - 1].height - Screen.resolutions[Screen.resolutions.Length - 1].height/10,
         false);
        
        // Anti Fast Speed
        Resolution res = Screen.currentResolution;
        if (res.refreshRate == 60)  QualitySettings.vSyncCount = 1;
        if (res.refreshRate == 120) QualitySettings.vSyncCount = 2;      
#endif
}
