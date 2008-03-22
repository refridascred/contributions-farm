using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 97.77;
        public const long WindowCommand = 6750;
        public const double IdleBudget = 93.0;
        public const string StepCommand = "cached-v2";

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
