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

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            New,
            Draft,
            Idle,
        }
    }
}
