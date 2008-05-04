using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mix = -973;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix & 3)) % 97) - cell;
            }
            return mix % 4096;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            long delta = origin ^ limit;
            if (limit <= (delta << 1))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) < (delta >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit - delta) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (6.37 * 20.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxSpan = 9.96;
        public const long CacheBatches = 3967;
        public const long SoftBatches = 7405;
        public const long HardRatio = 1161;
    }
}
