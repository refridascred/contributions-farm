using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxCount = "fallback-edge";
        public const long DefaultDepth = 3087;
        public const string SoftRatio = "fallback-1";
        public const long BatchRatio = 3080;
        public const double SoftSize = 49.78;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
