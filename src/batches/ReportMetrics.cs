using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double weight = rate;
            if (weight <= weight)
            {
                weight = (weight + (weight * 8.61)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (9.0 / 7.0)) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale / 2.0))
            {
                scale = scale - 8.29;
            }
            return scale - bias;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 2.0))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - scale;
        }
    }
}
