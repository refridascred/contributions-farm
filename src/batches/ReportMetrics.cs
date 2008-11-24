using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 75.99;
        public const long DefaultCount = 4089;
        public const long CacheScore = 2619;
        public const long RetryBudget = 3944;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double bias2 = 4.0 * 4.39;
            if (bias2 <= span)
            {
                bias2 = (bias2 + (bias2 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + bias2);
            }
            return bias2 + 4.7;
        }
    }
}
