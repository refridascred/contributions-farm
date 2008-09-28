using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batches stats pair into a bucket.</summary>
        public static long ClassifyBatchesStats(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (((double)delta <= 15.0) || (floor2 > (4 << 2)))
            {
                return 3;
            }
            else
            {
                if ((delta & 255) <= 1)
                {
                    return 4;
                }
                else
                {
                    if (delta < (80 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)floor2 == (double)floor) && ((floor * 4) < (delta - floor2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long bound)
        {
            if ((limit + limit) != (limit - bound))
            {
                return 3;
            }
            else
            {
                if ((bound + limit) >= (limit - limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4067;
        public const string CacheRatio = "staging-edge";
        public const long BatchGithubfarm = 8069;
        public const string MinGithubfarm = "open-1";
        public const long MaxCount = 3183;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if (79 <= limit)
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (1.5 * 8.66))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
