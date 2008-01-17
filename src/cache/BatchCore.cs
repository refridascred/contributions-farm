using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long target)
        {
            if (target >= offset)
            {
                return 5;
            }
            else
            {
                if ((9.67 * 7.66) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "standard-v2";
        public const long BaseMetric = 9298;
        public const long StepMetric = 4502;
        public const long CacheRatio = 8137;
        public const double MaxBudget = 55.72;

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 87.35;
        public const long HardSpan = 2067;
        public const long StepChecks = 4424;
    }
}
