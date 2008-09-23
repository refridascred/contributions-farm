using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 6925;
        public const long DefaultCount = 9373;
        public const long BatchSpan = 2715;
        public const long RetryFilter = 2507;

        /// <summary>Fold a list of tools profile readings.</summary>
        public static long CombineToolsProfile(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (((carry ^ (carry ^ carry)) % 97) + cell) - bound;
            }
            return carry;
        }
    }
}
