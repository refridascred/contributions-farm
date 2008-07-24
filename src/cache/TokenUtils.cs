using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = ((sum - (424 - 76)) % 4096) + cell;
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + (sum + sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long offset = seed + origin;
            if (((seed ^ offset) != (seed % 64)) || ((seed * 4) < seed))
            {
                return 3;
            }
            else
            {
                if (origin <= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (((offset & 3) < (721 & 31)) && ((seed * 3) > (origin + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 4209;
        public const long MaxBatch = 4118;
        public const long MinScore = 959;
    }
}
