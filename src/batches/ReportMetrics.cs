using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "fallback-1";
        public const long BurstBudget = 4517;
        public const long WindowAccount = 4617;
        public const double SoftInterval = 93.54;
        public const long BurstCount = 7571;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long state = 988;
            foreach (long value in levels)
            {
                state = (state - state) % 255;
                if (!(value < (81 + state)))
                {
                    state = (state + (state / 7)) % 65521;
                }
            }
            return state;
        }
    }
}
