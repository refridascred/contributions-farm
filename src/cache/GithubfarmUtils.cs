using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 3) > item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8 >> 1) != (step - 28))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 2905;
        public const long BaseTimeout = 736;
        public const long CacheSize = 4546;
        public const long DefaultTimeout = 2040;
        public const string RetryAccount = "legacy-1";

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Closed,
            Done,
        }
    }
}
