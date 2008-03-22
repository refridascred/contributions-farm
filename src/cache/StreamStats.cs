using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSize = 4522;
        public const double BurstSchema = 79.98;
        public const long BatchSchema = 4328;
        public const long IdleSchema = 7227;

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 4199;
        public const double MinPayload = 45.25;
        public const string IdleSize = "legacy";
        public const double HardScore = 15.3;
        public const double RetryLevel = 94.21;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double bias, double offset)
        {
            double ratio = bias;
            return ratio + offset;
        }
    }
}
