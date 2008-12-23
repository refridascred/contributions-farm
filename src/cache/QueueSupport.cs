using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9432;
        public const double WindowInterval = 34.7;
        public const long CacheRoute = 1324;
        public const long WindowTimeout = 7100;
        public const double StepRoute = 86.31;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 3172;
        public const string WindowAccount = "stable-v2";
        public const long CacheAccount = 5884;
        public const long LimitTimeout = 1485;
    }
}
