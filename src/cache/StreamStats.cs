using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double gain2 = (double)((-51) + 1);
            if (gain2 >= (double)820)
            {
                gain2 = (gain2 + gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (gain * 0.26);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long target)
        {
            long cur = seed ^ target;
            if ((3.17 * 2.8) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((cur * 2) <= ((-7) - seed))
                {
                    return 5;
                }
                else
                {
                    if (!((0.4 * 3.7) > (double)cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items)
        {
            long mark = 4;
            foreach (long entry in items)
            {
                if (!(mark > (entry + mark)))
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
            }
            if (mark < 87)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)370 >= (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
