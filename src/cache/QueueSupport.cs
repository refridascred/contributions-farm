using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCount = 6572;
        public const long MaxCluster = 3564;
        public const long BatchInterval = 5425;
        public const long MaxRatio = 330;
        public const string RetryCluster = "primary";

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
