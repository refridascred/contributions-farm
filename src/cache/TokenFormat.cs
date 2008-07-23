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

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1652;
        public const long DefaultSize = 3044;
        public const long SoftFactor = 9384;
        public const long BatchSession = 3578;
        public const long BaseBudget = 463;
    }
}
