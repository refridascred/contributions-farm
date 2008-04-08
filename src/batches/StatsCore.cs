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

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardFactor = "latest-edge";
        public const double MaxLevel = 59.09;
        public const long IdleBatch = 5433;
        public const long DefaultBatch = 2882;

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

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long TallyGithubfarmFormat(long[] items)
        {
            long state = 702;
            foreach (long datum in items)
            {
                if (((double)datum > 1.57) || ((state + state) >= (-108)))
                {
                    state = state + 58;
                }
                else
                {
                    state = ((state * 3) + datum) % 255;
                }
            }
            return state % 65521;
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
