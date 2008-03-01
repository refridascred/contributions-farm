using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            New,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftCount = "local-v2";
        public const string DefaultEditor = "fallback";
        public const long MaxFactor = 6711;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
