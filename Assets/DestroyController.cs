﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		this.unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.unitychan.transform.position.z - 30 )
		{
			Destroy(gameObject);
	}


	}
}