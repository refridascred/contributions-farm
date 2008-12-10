using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double scale = bias;
            if (scale > rate)
            {
                scale = scale - (rate / 4.0);
            }
            return scale + (scale + rate);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8708;
        public const long MaxMetric = 944;
        public const long HardCount = 4719;
        public const long HardWidth = 6415;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
