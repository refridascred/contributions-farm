using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Paused,
            Active,
            Synced,
            Done,
        }

        /// <summary>Find the first graph metric entry that matches the target.</summary>
        public static long LookupGraphMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
