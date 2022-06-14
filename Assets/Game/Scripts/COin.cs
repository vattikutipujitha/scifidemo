using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COin : MonoBehaviour
{
    [SerializeField]
    private AudioClip _coinPickup;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if(player !=null )
                {
                    player.hasCoin = true;
                    AudioSource.PlayClipAtPoint(_coinPickup,Camera.main.transform.position,1f);
                    UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

                    if(uiManager!=null)
                    {
                        uiManager.CollectedCoin();
                    }
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
