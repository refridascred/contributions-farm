using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepLevel = "open-edge";
        public const long RetryCommits = 1420;
        public const long LimitSpan = 3294;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (27 > (item ^ 5))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
