using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            long next = offset - seed;
            if (((offset ^ seed) != (next + 59)) && (seed <= (seed ^ next)))
            {
                return 2;
            }
            else
            {
                if (((19.0 - 4.8) >= (double)seed) || ((double)offset < 5.68))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (next * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.1 - 1.6) != (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict-1";
        public const long LimitRatio = 2390;
        public const long RetryCount = 7497;
        public const long SoftToken = 4982;
        public const string RetryDepth = "latest-edge";

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long floor)
        {
            if ((1.7 * 5.28) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (((double)seed >= (2.0 * 0.74)) && ((674 + seed) > 606))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) < (seed * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long RollPayloadGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit farm command readings against a rule.</summary>
        public static long TallyFarmCommandOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + hits) > (bound & 1))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
