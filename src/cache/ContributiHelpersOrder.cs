using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 7378;
        public const double CacheFactor = 60.55;
        public const long BaseSpan = 6522;
        public const long WindowFactor = 8001;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2872;
        public const long BaseChecks = 3340;
        public const string CacheChecks = "alpha";
        public const long DefaultInterval = 7870;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
