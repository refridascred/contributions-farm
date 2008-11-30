using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 5725;
        public const long SoftToken = 3573;
        public const long SoftFactor = 705;
        public const long BatchRatio = 6212;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSpan = 7936;
        public const long CacheChannel = 5321;
        public const long WindowWidth = 677;
        public const long RetryChannel = 2988;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepScore = 9665;
        public const long IdleCache = 5903;
        public const string HardCache = "fallback-1";
        public const long RetryCache = 274;
        public const string CacheCount = "local-v2";
    }
}
