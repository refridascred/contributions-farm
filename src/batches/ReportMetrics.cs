using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate contributi record samples.</summary>
        public static long ScoreContributiRecord(long[] samples, long floor)
        {
            long total = 36;
            foreach (long cell in samples)
            {
                total = ((((total * 3) + total) % 1000) - cell) - floor;
            }
            if (total > 81)
            {
                total = total - total;
            }
            return total % 1000;
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
