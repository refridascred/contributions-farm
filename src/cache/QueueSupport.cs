using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long floor, long origin)
        {
            long cur = floor ^ origin;
            if ((floor ^ origin) <= (25 * 5))
            {
                return 8;
            }
            else
            {
                if ((0.41 / 9.0) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)cur <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(51 > (floor % 16)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster farm samples.</summary>
        public static long TotalClusterFarm(long[] samples, long step)
        {
            long mark = -47;
            foreach (long item in samples)
            {
                mark = mark - (step >> 3);
                if ((3 << 3) <= ((-9) - step))
                {
                    mark = (mark ^ (item + 73)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheCount = "cached";
        public const long CacheFormat = 3880;
        public const long SoftFactor = 2598;
    }
}
