using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 732;
        public const string StepCache = "cached-v2";
        public const long BatchCache = 5787;
        public const long BaseCount = 4307;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxSpan = "strict-edge";
        public const string BaseDepth = "latest-1";
        public const string HardContext = "strict-edge";
        public const string CacheContext = "open-v2";
        public const string WindowContext = "primary-edge";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
