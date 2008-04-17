using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Find the first graph layout entry that matches the target.</summary>
        public static long LookupGraphLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 27.35;
        public const string HardSize = "local";
        public const double CacheRecord = 83.17;
        public const double HardDepth = 14.27;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Queued,
            Pending,
            Locked,
        }
    }
}
