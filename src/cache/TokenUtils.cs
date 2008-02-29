using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long WeighCacheCommits(long[] values)
        {
            long sum = 151;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum - 59)) % 255;
                sum = ((sum * 3) + (sum * 5)) % 4096;
                if ((double)(long)values.Length <= (19.0 - 9.0))
                {
                    sum = ((sum << 3) ^ (datum >> 2)) % 101;
                }
            }
            if (sum < 7)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (((target + target) < (target & 7)) || ((bound + target) <= bound))
            {
                return 5;
            }
            else
            {
                if ((bound & 63) == (382 + 885))
                {
                    return 3;
                }
                else
                {
                    if ((bound - target) != (target - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (bound & 31))
                        {
                            return 2;
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
        public const string HardCount = "cached-edge";
        public const long BatchLevel = 4965;
        public const string BurstBatches = "strict";
    }
}
