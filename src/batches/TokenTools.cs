using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 432;
        public const long RetryBudget = 4030;
        public const long BaseDepth = 9070;
        public const long BaseStream = 7242;
        public const long HardStream = 5678;

        /// <summary>Check that every batches token entry stays within the limit.</summary>
        public static bool GuardBatchesTokenLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
