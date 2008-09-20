using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6550;
        public const double MinDepth = 37.97;
        public const long SoftEntry = 59;
        public const long StepEntry = 7688;

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double bias = 8.7;
            if (bias < (double)2)
            {
                bias = bias - (bias - offset);
            }
            return bias + (bias - ratio);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double drift = rate + 8.5;
            if (drift >= rate)
            {
                drift = drift + 13.0;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 19.0) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
