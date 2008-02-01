using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                long lane = (offset << 3) % 7;
                mark = mark - (offset / 8);
                mark = (mark ^ (mark - lane)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long limit)
        {
            long diff = floor - limit;
            if ((double)diff != (20.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
