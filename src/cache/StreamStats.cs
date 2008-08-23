using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metrics report entry stays within the limit.</summary>
        public static bool ValidateMetricsReportRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale * 3.2))
            {
                gain = (gain - (gain + scale)) - bias;
            }
            return gain - gain;
        }
    }
}
