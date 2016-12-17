using UnityEngine;
using System.Collections;

public class boxHide : MonoBehaviour {
    public GameObject character;
    public GameObject box;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {

            // Hide button
             GameObject.Find("snakeWithShootingGun").transform.localScale = new Vector3(0, 0, 0);
           // GameObject.Find("snakeWithShootingGun").SetActive(false);
            box.transform.position = character.transform.position;
            // Show button         
            //GameObject.Find("Box").transform.localScale = new Vector3(1, 1, 1);

            //character.SetActive(false);

            //print("didnt set bt im here");
            //box.SetActive(true);

            //GameObject.Find("snakeWithShootingGun").GetComponent<Renderer>().enabled = false;
            GameObject.Find("Box").transform.GetComponent<Renderer>().enabled = true;

        }


        if (Input.GetKeyDown(KeyCode.E))
        {

            // Hide button
            GameObject.Find("snakeWithShootingGun").transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            // Show button         
            //GameObject.Find("Box").transform.localScale = new Vector3(1, 1, 1);

            //character.SetActive(false);

            //print("didnt set bt im here");
            //box.SetActive(true);

            GameObject.Find("Box").GetComponent<Renderer>().enabled = false;
            ///GameObject.Find("Box").transform.localScale = new Vector3(1, 1, 1);

        }

    }
}
