using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((value / 6) > value)
                {
                    mix = (mix + (mix << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long limit2)
        {
            if ((double)limit2 < (double)54)
            {
                return 5;
            }
            else
            {
                if ((double)limit2 <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (!(9.3 > (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long step, long origin)
        {
            if ((origin >= (origin + origin)) || (7.8 < (double)step))
            {
                return 1;
            }
            else
            {
                if (!((4 + step) >= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= 12.0)
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
    }
}
