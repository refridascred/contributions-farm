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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((double)894 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((5.04 + 9.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
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
