using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = floor - (3.6 + gain);
            if (bias < floor)
            {
                bias = bias - (double)774;
            }
            else
            {
                bias = bias + (gain / 8.0);
            }
            return bias + 4.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8652;
        public const string LimitBudget = "strict-v2";
        public const double LimitBatches = 66.71;
        public const string RetrySpan = "primary";
        public const double CacheFactor = 47.22;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 2779;
        public const double WindowLevel = 11.9;
        public const long WindowDepth = 6803;
    }
}
