﻿using SimpleJSON;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour {


	private string url = "https://pim.pythagoras.se/py_datamanager_conference/rest/v1/building/name/ISAFJORDSGATAN?orderAsc=true";
	private string apiKey = "BMOOROR499fMA4NOSBMZ30189884MXO3MG4";


	IEnumerator Start() {

/*		
		headers.Add ("api_key", apiKey);

		WWW www = new WWW(url, null, headers);
		yield return www;
		print (www.text);
		string response = www.text;

		var a = new Building ();
		a.id = 
		a.uid = 
				a.created = 
					a.updated = 
						a.name = 
							a.popularName = 
								a.markerType = 
									a.geoLocation = 
										a.origin = "SpaceManager";

	} 
	*/

		//Building b = JsonUtility.FromJson<Building> (response);

		BuildingList lb = JsonUtility.FromJson<BuildingList> (JsonResponseExamples.Building);
		yield return null;
		/*
		Building b = JsonUtility.FromJson<Building> (JsonResponseExamples.Building);
		print (b.id);
		print (b.uid);
		print ( b.created);
		print (b.updated);
		print (b.name);
		print (b.popularName);
		print (b.markerType);
		print (b.geoLocation.x);
		print (b.geoLocation.y);
		print (b.geoLocation.rotation);
		print (b.origin);
		*/

	}


}
