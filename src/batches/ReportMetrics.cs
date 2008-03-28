using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 22.9;
        public const long BurstDepth = 7488;
        public const double WindowTimeout = 22.54;
        public const long HardChannel = 2398;
        public const double BurstChannel = 2.96;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias;
            return (gain - (double)0) + span;
        }

        /// <summary>Project the next batch cluster value.</summary>
        public static double ProjectBatchCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (rate / 4.0))
            {
                ratio = ratio - (ratio * 6.6);
            }
            else
            {
                ratio = ratio + (span * 16.0);
            }
            return ratio + 16.0;
        }
    }
}
