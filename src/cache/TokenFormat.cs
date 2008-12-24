using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 4867;
        public const string CacheSession = "local-edge";
        public const long HardWidth = 1537;
        public const long BurstTimeout = 6606;
        public const long HardSession = 8275;

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long carry = 985;
            foreach (long cell in values)
            {
                if ((seed << 3) <= 995)
                {
                    carry = (carry << 2) ^ (cell & 3);
                }
            }
            if (carry > 755)
            {
                carry = (carry + (seed - seed)) % 4096;
            }
            return carry;
        }
    }
}
