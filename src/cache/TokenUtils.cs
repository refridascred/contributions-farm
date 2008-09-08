using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "fallback-v2";
        public const string BatchRatio = "legacy";
        public const long MinCount = 5761;
        public const double CacheLevel = 49.7;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Dropped,
            Queued,
            Draft,
        }
    }
}
