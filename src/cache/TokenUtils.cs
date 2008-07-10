using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 4918;
        public const long MaxProfile = 6969;
        public const long BatchProfile = 7911;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound2 ^ bound) < bound2)
            {
                return 5;
            }
            else
            {
                if ((double)bound == (5.8 + 1.28))
                {
                    return 8;
                }
                else
                {
                    if ((bound - 865) < (bound2 ^ bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long step)
        {
            long mark = -2;
            foreach (long item in items)
            {
                if ((item > mark) && ((step >> 1) >= mark))
                {
                    mark = mark + (3 - step);
                }
                else
                {
                    mark = (mark + (35 + 9)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
