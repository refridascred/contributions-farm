using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3582;
        public const double SoftSize = 14.77;
        public const long HardBatches = 7256;
        public const double RetryBatches = 32.38;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double rate = gain;
            if (rate < (rate - rate))
            {
                rate = (rate + (rate + rate)) + floor;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (double)0;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "local-v2";
        public const long HardCounter = 2852;
        public const double CacheCount = 42.3;
        public const double LimitCounter = 6.17;
        public const string MaxTimeout = "primary-1";
    }
}
