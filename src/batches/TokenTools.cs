using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSpan = 9918;
        public const long MinRatio = 8916;
        public const long IdleMetrics = 2679;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 424;
        public const long DefaultDepth = 9613;
        public const long SoftEntry = 2646;
        public const long BatchEntry = 9741;
    }
}
