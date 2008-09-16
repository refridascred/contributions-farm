using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheScore = 284;
        public const double BatchEntry = 15.87;
        public const long MaxEntry = 2790;
        public const double SoftFactor = 92.28;

        /// <summary>Digest a series of already format entries.</summary>
        public static long TallyAlreadyFormat(long[] values, long step)
        {
            long carry = 542;
            foreach (long cell in values)
            {
                carry = ((((carry << 2) ^ carry) % 4096) + cell) + step;
            }
            return carry;
        }

        /// <summary>Digest a series of cache channel entries.</summary>
        public static long TotalCacheChannel(long[] data, long target)
        {
            long total = 15;
            foreach (long entry in data)
            {
                if ((target << 3) < (0 & 15))
                {
                    total = (total * 3) + (entry + 871);
                }
                else
                {
                    total = total - (target - total);
                }
            }
            return total;
        }
    }
}
