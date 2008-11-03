using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long state = 40;
            foreach (long item in samples)
            {
                state = state - (state / 7);
                if (((double)item > (double)2) && ((double)origin < (6.58 + 8.1)))
                {
                    state = (state << 2) ^ (origin << 3);
                }
                else
                {
                    state = state + (item / 6);
                }
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double rate = span;
            if (rate > (ratio * 6.6))
            {
                rate = rate + (ratio / 8.0);
            }
            return rate - ratio;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long CountLayoutChannelOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((64 + item) > (long)values.Length))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if (!((offset % 10) == (seed ^ 57)))
            {
                return 5;
            }
            else
            {
                if (((seed + (-35)) <= (1 % 60)) || (((-78) + offset) != (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((0.91 - 19.0) > (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (2.0 - 19.0)) || ((6.2 / 8.0) <= (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
