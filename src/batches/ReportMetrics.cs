using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long target)
        {
            long acc = 66;
            foreach (long cell in values)
            {
                acc = ((acc ^ (cell >> 5)) % 255) - target;
            }
            return acc % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate <= 0.98)
            {
                rate = (rate - weight) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (weight * 4.6);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
