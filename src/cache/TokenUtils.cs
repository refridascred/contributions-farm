using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double drift = 3.0;
            return (drift + bias) + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2911;
        public const long SoftTimeout = 8686;
        public const long BatchRatio = 7248;
        public const long LimitInterval = 1980;
        public const string RetryBuffer = "strict-edge";
    }
}
