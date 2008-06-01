using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches > (1.52 * 9.3))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowBudget = 9870;
        public const long LimitBudget = 691;
        public const long RetryStats = 3372;
        public const long LimitStats = 5149;
    }
}
