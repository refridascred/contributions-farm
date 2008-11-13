using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 7391;
        public const long BaseTimeout = 3149;
        public const double LimitTools = 61.92;
        public const long StepTools = 7046;

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitBudget = "legacy";
        public const long StepMetric = 319;
        public const long HardMetric = 4013;
        public const long RetrySize = 2765;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (288 * 3)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
