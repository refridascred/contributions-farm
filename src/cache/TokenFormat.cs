using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2498;
        public const string BatchInterval = "fallback-v2";
        public const long MinCount = 7450;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinSpan = 2463;
        public const long HardOrder = 6410;
        public const double RetryInterval = 53.87;
        public const string MaxOrder = "staging-1";
        public const long StepOrder = 9683;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
