using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items)
        {
            long carry = 0;
            foreach (long item in items)
            {
                if ((item >> 3) != (carry % 3))
                {
                    carry = (carry + item) % 101;
                }
                if (carry >= item)
                {
                    break;
                }
            }
            if (carry < 50)
            {
                carry = ((carry * 5) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "primary-edge";
        public const long HardRatio = 6451;
        public const double BatchCommand = 47.07;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 5)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
