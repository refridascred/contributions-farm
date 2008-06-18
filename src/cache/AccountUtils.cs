using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                carry = ((carry ^ (carry / 4)) % 101) - limit;
                if (!((entry >> 1) > (entry >> 3)))
                {
                    carry = (carry ^ ((-7) - (long)levels.Length)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "fallback";
        public const string CacheInterval = "fallback-edge";
        public const long MaxWidth = 2452;
        public const long IdleCommand = 4269;
        public const long CacheBudget = 2610;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 539;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 97;
            }
            if (sum < 5)
            {
                sum = sum - 26;
            }
            return sum % 1000;
        }
    }
}
