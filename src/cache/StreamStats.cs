using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long SeriesToolsOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 3824;
        public const long BaseReport = 7894;
        public const long HardReport = 5874;
        public const string MaxReport = "cached";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9170;
        public const double IdleLevel = 13.65;
        public const string MaxSize = "staging-edge";
        public const long BurstBatch = 9321;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
