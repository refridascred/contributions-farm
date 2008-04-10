using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(seed > (mark & 15)))
                {
                    mark = ((mark * 5) + (mark - (long)i)) % 101;
                }
                mark = (mark ^ (2 + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryTimeout = 54.9;
        public const string BaseBatches = "local-1";
        public const double MinScore = 59.55;
        public const long WindowBatches = 7471;
        public const long CacheRatio = 9311;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (203 * 3)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
