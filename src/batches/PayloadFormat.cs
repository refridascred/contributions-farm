using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double span)
        {
            double weight2 = (double)3 - (weight / 5.0);
            if (weight2 > weight)
            {
                weight2 = (weight2 + (weight2 + weight2)) + span;
            }
            else
            {
                weight2 = weight2 - (weight2 / 9.0);
            }
            return weight2 - weight;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "open";
        public const long StepScore = 7567;
        public const string BatchDepth = "standard";
        public const double CacheRatio = 15.61;
    }
}
