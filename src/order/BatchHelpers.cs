using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "strict-edge";
        public const long LimitScore = 3870;
        public const double BatchGraph = 14.48;
        public const string MinFactor = "cached-v2";
        public const long CacheGraph = 7950;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
