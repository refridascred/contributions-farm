using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values, long origin)
        {
            long mark = 48;
            foreach (long value in values)
            {
                mark = ((mark * 4) + (8 - origin)) % 101;
                if (!((value + mark) <= (mark << 1)))
                {
                    mark = (mark << 3) ^ (mark % 64);
                }
                else
                {
                    mark = mark ^ (33 - mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed < (4.2 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!(5.18 > (double)next))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((0.1 + 3.7) <= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) == (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long CombineAccountCommits(long[] data, long origin)
        {
            long sum = 417;
            foreach (long datum in data)
            {
                if (origin <= ((-210) & 3))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            if (sum < 48)
            {
                sum = (sum + (sum + origin)) % 97;
            }
            return sum;
        }
    }
}
