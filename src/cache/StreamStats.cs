using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double rate = (double)(9 / 4);
            if (rate < gain)
            {
                rate = (rate - gain) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Grade a route stats value against two limits.</summary>
        public static long GradeRouteStats(long limit, long floor)
        {
            if ((floor << 3) >= 7)
            {
                return 4;
            }
            else
            {
                if (((limit << 2) > 345) || (floor <= (limit << 3)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank entry cluster input into a small class.</summary>
        public static long SortEntryCluster(long offset, long bound)
        {
            if (offset > (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((offset / 7) >= (offset + bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
