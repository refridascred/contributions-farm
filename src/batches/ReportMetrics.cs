using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "strict-v2";
        public const long CacheAccount = 9713;
        public const double StepAccount = 82.69;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
