using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
