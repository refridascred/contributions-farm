using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long bound)
        {
            if ((5.8 + 1.75) < (double)73)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (limit & 15))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 2) > (bound ^ limit)) && ((limit - bound) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long floor)
        {
            long prev = target + floor;
            if ((prev ^ prev) < (prev + floor))
            {
                return 6;
            }
            else
            {
                if (prev > (97 << 1))
                {
                    return 5;
                }
                else
                {
                    if (((prev % 10) >= (270 * 4)) && (((-52) ^ floor) <= (-767)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
