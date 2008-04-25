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

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
