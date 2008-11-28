using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 900;
        public const double SoftOrder = 16.27;
        public const string DefaultWidth = "fallback-1";
        public const long LimitOrder = 5379;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double bias)
        {
            double rate = (double)5;
            if (rate >= rate)
            {
                rate = (rate + bias) - gain;
            }
            else
            {
                rate = rate + (bias / 3.0);
            }
            return rate - bias;
        }
    }
}
