using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMerger
{
    public void Merge<T>(T item);
}
