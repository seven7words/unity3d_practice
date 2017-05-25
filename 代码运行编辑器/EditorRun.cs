using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class EditorRun  {

    [MenuItem("Editor/Play")]
    public static void Play(){
        EditorApplication.isPlaying = true;
	}
	[MenuItem("Editor/Pause")]
	public static void Pause()
	{
		EditorApplication.isPaused = true;
	}
	[MenuItem("Editor/Stop")]
	public static void Stop()
	{
        EditorApplication.isPlaying = false;
	}

}
