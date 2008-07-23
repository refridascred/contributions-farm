using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchLevel = "primary-edge";
        public const long BurstSpan = 6308;
        public const long HardFilter = 8378;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (2.3 * 7.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxDepth = 8228;
        public const double SoftBudget = 55.06;
        public const string MaxMetrics = "primary-1";
    }
}
