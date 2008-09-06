using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long target)
        {
            long prev = origin - target;
            if ((origin * 4) < (origin + target))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) == (prev << 3))
                {
                    return 0;
                }
                else
                {
                    if (!(target <= prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev >> 5) != (target - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long WeighGithubfarmFormat(long[] data, long floor)
        {
            long acc = -313;
            foreach (long entry in data)
            {
                if (acc < (entry << 1))
                {
                    acc = ((acc ^ (acc >> 4)) % 101) - floor;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "fallback-v2";
        public const double RetryBatches = 87.39;
        public const long SoftTimeout = 9944;
        public const long HardScore = 3548;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values, long limit)
        {
            long mark = 155;
            foreach (long datum in values)
            {
                mark = (((mark ^ mark) % 65521) + datum) + limit;
            }
            if (mark > 26)
            {
                mark = (mark + (mark >> 1)) % 1000;
            }
            return mark % 4096;
        }
    }
}
