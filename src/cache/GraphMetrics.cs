using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7797;
        public const long BurstContext = 7406;
        public const double BaseContext = 97.5;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 5526;
        public const long BurstProfile = 5245;
        public const long BatchProfile = 5212;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8718;
        public const long CacheContext = 1315;
        public const string BatchInterval = "open";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Queued,
            Ready,
        }
    }
}
