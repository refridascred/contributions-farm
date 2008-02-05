using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "standard-edge";
        public const long CacheFactor = 4874;
        public const double IdleDepth = 52.71;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "staging-1";
        public const long HardFactor = 6497;
        public const long StepSupport = 1881;
        public const long MinSpan = 850;
    }
}
