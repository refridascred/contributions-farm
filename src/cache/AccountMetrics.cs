using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double gain = (9.01 / 9.0) / 9.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (bias - 8.56)) + (double)(long)i) + weight;
            }
            return gain + (double)4;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double mean = 1.04;
            if (mean >= (mean / 7.0))
            {
                mean = (mean + mean) + ratio;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - mean;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool GuardSupportContextLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double ratio = (double)(3 - 83);
            if (ratio <= (floor - floor))
            {
                ratio = ratio - (scale * 7.16);
            }
            return ratio + (double)86;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double mean = 17.0;
            if (mean < (floor / 8.0))
            {
                mean = mean + (scale - 2.1);
            }
            else
            {
                mean = mean - (8.96 * 1.0);
            }
            return mean - (scale + floor);
        }
    }
}
