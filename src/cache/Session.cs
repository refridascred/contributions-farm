using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (floor < 9)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Draft,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchScore = "local";
        public const string CacheEditor = "fallback";
        public const double BurstInterval = 30.81;
    }
}
