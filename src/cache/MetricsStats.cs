using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double BlendCounterTools(double scale, double floor)
        {
            double drift = 11.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - scale;
            }
            return drift - 12.0;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double scale = bias;
            if (scale <= (bias2 + 2.6))
            {
                scale = scale - (double)743;
            }
            else
            {
                scale = scale - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (2.5 - scale)) + (double)(long)i;
            }
            return scale + 8.0;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Paused,
            Idle,
            Closed,
            Active,
        }
    }
}
