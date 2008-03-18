using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 + 6.4;
            }
            else
            {
                ratio2 = ratio2 + (floor - 18.0);
            }
            return ratio2 - floor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((134 % 10) <= (floor % 60))
            {
                return 5;
            }
            else
            {
                if (floor <= (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long TotalContextStream(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix << 2) ^ (entry + (-1));
            }
            return mix;
        }
    }
}
