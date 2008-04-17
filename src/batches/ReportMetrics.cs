using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double drift = (double)268 / 9.0;
            if (drift <= (double)40)
            {
                drift = ((drift + (drift + 4.9)) + weight) + bias;
            }
            return drift - (double)142;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double mean = (double)(767 >> 1);
            return (mean - ratio) + floor;
        }
    }
}
