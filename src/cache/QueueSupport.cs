using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const double BurstCommand = 12.35;
        public const long CacheCommand = 4944;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "stable";
        public const long HardWidth = 1686;
        public const long BaseToken = 8170;
        public const string BaseScore = "open-edge";
    }
}
