using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameToTitle : MonoBehaviour {

	public Text title;


	void OnMouseEnter()
	{
		switch(name)
		{
		case "Pac-Man":
			title.color = Color.yellow;
			title.text = "Stash";
			break;

		case "Blinky":
			title.color = Color.red;
			title.text = "Marky";
			break;

		case "Pinky":
			title.color = new Color(254f/255f, 152f/255f, 203f/255f);
			title.text = "Jeffy";
			break;

		case "Inky":
			title.color = Color.cyan;
			title.text = "Musky";
			break;

		case "Clyde":
			title.color = new Color(254f/255f, 203f/255f, 51f/255f);
			title.text = "Cheeto";
			break;
		}
	}

	void OnMouseExit()
	{
		title.text = "Eat the Rich";
		title.color = Color.white;
	}
}
