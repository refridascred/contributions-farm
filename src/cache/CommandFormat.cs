using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 10.05;
        public const long LimitSpan = 2409;
        public const long CachePayload = 665;
        public const long WindowRatio = 7007;
        public const long BatchSize = 7778;

        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long GradeStatsCache(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((5 & 127) <= (gap + gap))
            {
                return 1;
            }
            else
            {
                if (((double)0 > (double)bound2) || (bound2 < (bound & 7)))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (bound2 % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((436 + bound) < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command cluster entries.</summary>
        public static long TallyCommandCluster(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                bool valid = (mix >> 3) > mix;
                if (valid || ((mix + reading) < (mix - mix)))
                {
                    mix = mix - (mix / 8);
                }
                mix = (mix + (reading * 2)) % 97;
            }
            if (mix > 28)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            if (2.0 < (double)floor)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (3.42 * 3.09))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - limit) >= (limit >> 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
