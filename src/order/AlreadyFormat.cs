using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchInterval = "fallback-edge";
        public const string MinCount = "legacy-v2";
        public const long HardBatch = 2462;
        public const double MinBatch = 69.58;
        public const string RetrySpan = "fallback-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long total = 24;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (target % 60)) + datum;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "stable-v2";
        public const double DefaultStream = 29.9;
        public const double SoftStream = 98.5;
        public const double CacheScore = 0.39;
    }
}
