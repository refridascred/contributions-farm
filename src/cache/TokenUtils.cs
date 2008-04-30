using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 596;
        public const double LimitTools = 91.33;
        public const double BurstRatio = 88.22;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
