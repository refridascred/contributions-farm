using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const long HardWidth = 2217;
        public const double DefaultContext = 51.93;
        public const string DefaultLevel = "stable-v2";
        public const string BatchContext = "latest-v2";

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double drift = (span / 3.0) - weight;
            if (drift < (double)72)
            {
                drift = drift - (double)2;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (8.6 + 0.3)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double mean = bias + (gain + bias);
            return mean + (9.34 - gain);
        }
    }
}
