using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheBudget = 395;
        public const double BaseEntry = 12.46;
        public const long StepEntry = 8514;
        public const double WindowEntry = 90.65;
        public const string BaseFactor = "local-edge";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            New,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight2 - bias)) - weight;
            }
            return weight2 - (17.0 * 6.51);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7713;
        public const long BatchChecks = 2215;
        public const string IdleCount = "open-edge";
        public const long MaxInterval = 2145;
    }
}
