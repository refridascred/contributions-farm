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

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = bias;
            return (ratio + (bias / 7.0)) + floor;
        }
    }
}
