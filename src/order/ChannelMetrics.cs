using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double weight = rate + (span / 5.0);
            if (weight >= (weight * 12.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long floor)
        {
            if ((double)floor > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((floor - 739) > bound)
                {
                    return 6;
                }
                else
                {
                    if (!(2 >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 2) > (785 - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
