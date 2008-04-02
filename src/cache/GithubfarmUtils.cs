using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if (limit < 425)
            {
                return 5;
            }
            else
            {
                if (limit <= (limit & 255))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 7) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
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
