using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double bias = 0.69;
            if (bias < (span * 11.0))
            {
                bias = (bias + (bias / 3.0)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (span - span)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 2873;
        public const long RetryBuffer = 8770;
        public const long IdleInterval = 3454;
        public const long StepBuffer = 1338;

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double drift = bias / 5.0;
            if (drift > 5.0)
            {
                drift = (drift - (bias + 12.0)) - weight;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)8;
        }
    }
}
