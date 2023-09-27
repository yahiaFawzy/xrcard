using UnityEngine;


public class test : MonoBehaviour
{
    WebViewObject viewObject;

    private void Start()
    {
        viewObject.LoadURL("");


        viewObject.Init(radius : 50, enableWKWebView : true);
        viewObject.LoadURL("https://profile.xr-card.com/Account/login");
    }

}
