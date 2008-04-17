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

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
