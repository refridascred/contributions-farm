using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (122 - acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long sum = 849;
            foreach (long sample in series)
            {
                if (((sum + sum) != ((-895) << 3)) || ((0.57 * 0.99) < (double)sum))
                {
                    sum = ((sum + (80 + limit)) % 4096) ^ sample;
                }
            }
            if (sum < 55)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long origin)
        {
            if (seed >= (origin - seed))
            {
                return 0;
            }
            else
            {
                if ((double)seed <= 3.0)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
