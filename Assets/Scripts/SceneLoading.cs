using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class SceneLoading : MonoBehaviour
{
    public string sceneName;
    public void OnClick()
    {
        Addressables.LoadSceneAsync(sceneName);
    }
}
