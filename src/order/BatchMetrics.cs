using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 26.39;
        public const long BurstReport = 8992;
        public const string RetryDepth = "primary";
        public const string StepReport = "latest";

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 439;
        public const long BatchSpan = 379;
        public const double LimitDepth = 5.61;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Rank session queue input into a small class.</summary>
        public static long ClassifySessionQueue(long floor, long step)
        {
            if ((floor * 3) >= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((2.0 / 8.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the githubfarm cache entries that pass the check.</summary>
        public static long TallyGithubfarmCacheMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ hits) != (item + 62))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
