using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
