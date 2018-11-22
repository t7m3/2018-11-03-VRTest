using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursolController : MonoBehaviour {

    public GameObject mushroomPrefab;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(Camera.main.transform.position,
                    Camera.main.transform.rotation * Vector3.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.name == "Platform1")
            {
                transform.position = hit.point + new Vector3(0, 0.1f, 0);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = transform.position;
            pos.y = -0.5f;
            Instantiate(mushroomPrefab, pos, Quaternion.identity);
        }


    }
}
