using UnityEngine;
using System.Collections;

public class ballscript : MonoBehaviour {
       public GameObject beachball;
       private int roomsize = 4;
       // Use this for initialization
       void Start () {
       	    for(int i=0;i<1000;i++){
	    	    Instantiate(beachball, new Vector3(Random.Range(-roomsize,roomsize), Random.Range(8,9.5f),Random.Range(-roomsize,roomsize)), Random.rotation);	     
		    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
