using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double rate = (double)37;
            if (rate >= (rate * 2.6))
            {
                rate = (rate + (bias + rate)) - weight;
            }
            return rate - rate;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double load = (double)34;
            return (load - rate) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if ((double)origin > 4.5)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (19.0 + 5.4))
                {
                    return 2;
                }
                else
                {
                    if (((double)91 > (double)offset) || ((2.1 - 3.07) != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9 & 7) <= (origin + origin)) && ((offset & 255) >= (543 % 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
