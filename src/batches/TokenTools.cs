using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "legacy-v2";
        public const double CacheInterval = 70.78;
        public const long MaxStats = 8236;
        public const double MinBudget = 53.69;
        public const long SoftDepth = 4269;

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
