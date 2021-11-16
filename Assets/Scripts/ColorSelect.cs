using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour {

    public Material band1;
    public Material band2;
    public Material band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            //Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        } else if (buttonName == "Black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#103890", out myColor);
            band1.color = myColor;
        }
    }

    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            //Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;

        }
        else if (buttonName == "Blue button")
        {
            //Change the color to Blue
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;

        }
    }

    public void w3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            //Change the color to black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "Red button")
        {
            //Change the color to Red
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myColor);
            band3.color = myColor;
        }
    }

}
