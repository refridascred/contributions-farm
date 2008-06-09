using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            return (rate + (double)51) + bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "stable-edge";
        public const long WindowTimeout = 5720;
        public const long HardInterval = 9109;

        /// <summary>Adjust a command profile reading.</summary>
        public static double AdjustCommandProfile(double weight, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + weight) - (double)(long)i) + span;
            }
            return rate - (double)91;
        }
    }
}
