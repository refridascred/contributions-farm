using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryDepth = 4.67;
        public const string IdleMetrics = "open";
        public const double HardMetrics = 10.27;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double drift = weight + (bias / 3.0);
            if (drift >= (double)51)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (weight * 14.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 57.16;
        public const long StepFactor = 4162;
        public const string DefaultFactor = "local";
        public const long CacheEditor = 739;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Queued,
        }
    }
}
