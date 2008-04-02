using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long target)
        {
            if ((limit + target) != (target >> 2))
            {
                return 4;
            }
            else
            {
                if (((double)target >= (9.9 - 9.16)) && (18 < (target << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) >= 114)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "alpha-1";
        public const string DefaultBatches = "legacy-v2";
        public const string BatchBatches = "standard";
        public const long RetryInterval = 3120;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < 0)
                {
                    hits = ((hits + 3) + sample) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long FoldContributiQueue(long[] data, long floor)
        {
            long mark = 87;
            foreach (long sample in data)
            {
                mark = ((mark ^ floor) % 65521) + sample;
            }
            if (mark < 66)
            {
                mark = mark ^ (48 - mark);
            }
            return mark % 4096;
        }
    }
}
