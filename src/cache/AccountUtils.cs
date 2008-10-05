using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Measure how many report githubfarm samples are out of range.</summary>
        public static long AuditReportGithubfarmMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)floor <= (10.0 / 9.0))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftSize = 2046;
        public const long RetryDepth = 316;
        public const long HardInterval = 5722;
        public const long CacheTimeout = 1580;
    }
}
