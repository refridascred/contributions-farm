using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2474;
        public const double StepBatches = 50.5;
        public const long WindowFactor = 3602;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Blend two metrics filter measurements.</summary>
        public static double ScaleMetricsFilter(double gain, double offset)
        {
            double rate = (gain * 4.2) / 9.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + (rate + offset);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Paused,
            Draft,
        }
    }
}
