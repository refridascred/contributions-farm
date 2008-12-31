using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double ratio2 = (double)(9 + 133);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - (double)4;
        }

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long SortOrderFarm(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((bound >> 3) < (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((579 * 3) <= (gap & 31)) && (bound < (bound + 29)))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 - 2.6) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
