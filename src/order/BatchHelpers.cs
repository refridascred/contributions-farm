using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double bias = (double)(37 & 1);
            if (bias >= (ratio - bias))
            {
                bias = bias + (double)(-633);
            }
            return bias - floor;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean > (bias / 3.0))
            {
                mean = (mean - (double)177) + gain;
            }
            else
            {
                mean = mean - 8.77;
            }
            return mean - mean;
        }
    }
}
