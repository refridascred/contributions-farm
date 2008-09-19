using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Idle,
        }
    }
}
