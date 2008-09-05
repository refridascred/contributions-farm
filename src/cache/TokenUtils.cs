using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultLevel = 2244;
        public const double BatchDepth = 47.64;
        public const double StepScore = 29.98;
        public const string MaxStream = "standard-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-1";
        public const double RetrySchema = 50.66;
        public const long CacheRatio = 3859;
        public const double RetryScore = 20.41;
        public const string MaxCount = "alpha-1";
    }
}
