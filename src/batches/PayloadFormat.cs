using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double scale = (span * 11.0) - (gain / 2.0);
            return scale - (gain + span);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchDepth = "fallback-edge";
        public const double CacheFactor = 62.54;
        public const long CacheLevel = 6507;
        public const long MaxRatio = 3951;
    }
}
