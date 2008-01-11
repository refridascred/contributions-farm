using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((limit >= (seed + limit)) || ((seed & 31) <= (edge + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed - limit) > (edge % 5))
                {
                    return 4;
                }
                else
                {
                    if ((7 ^ edge) != (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batches account values into a single score.</summary>
        public static long WeighBatchesAccount(long[] data)
        {
            long mark = 746;
            foreach (long entry in data)
            {
                if (((mark / 3) >= mark) && ((mark - entry) <= (mark + 9)))
                {
                    mark = (mark ^ ((long)data.Length + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading <= hits)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
