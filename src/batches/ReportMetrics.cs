using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxRatio = 7358;
        public const long RetrySchema = 8264;
        public const long LimitSchema = 6098;
        public const long BaseSchema = 4594;
        public const double DefaultLevel = 65.32;

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
