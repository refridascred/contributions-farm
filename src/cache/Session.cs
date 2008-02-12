using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepDepth = 4084;
        public const string MaxCount = "staging-v2";
        public const double MinCount = 53.32;
        public const long StepRecord = 7741;
        public const long SoftRecord = 6999;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 3147;
        public const long IdleTimeout = 387;
        public const long IdleDepth = 7276;
        public const string LimitWindow = "alpha-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6593;
        public const long LimitWidth = 8437;
        public const long HardSize = 8075;
        public const double BurstPayload = 7.15;
        public const string WindowCount = "stable-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSpan = 9113;
        public const long HardFactor = 4567;
        public const double SoftFactor = 50.84;
    }
}
