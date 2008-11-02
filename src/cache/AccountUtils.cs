using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleInterval = 64.67;
        public const long BurstTimeout = 6579;
        public const long LimitCommand = 1890;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 74.89;
        public const long MinStream = 9372;
        public const long CacheBudget = 6509;
        public const double HardStream = 28.18;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long score = 62;
            foreach (long value in readings)
            {
                score = ((((score * 4) + (score + score)) % 65521) ^ value) - offset;
            }
            if (score > 63)
            {
                score = score - (score << 3);
            }
            return score;
        }
    }
}
