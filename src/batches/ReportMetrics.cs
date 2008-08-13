using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 42.99;
        public const long BaseBuffer = 6126;
        public const long CacheBuffer = 9791;
        public const long StepBuffer = 5499;
        public const string BaseSize = "legacy-1";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double weight = (6.0 / 5.0) + (rate * 6.37);
            if (weight <= (offset * 8.23))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (rate - offset);
            }
            return weight + (double)78;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 94.83;
        public const double StepRecord = 41.26;
        public const long CacheRatio = 4484;
        public const double StepSize = 20.33;
    }
}
