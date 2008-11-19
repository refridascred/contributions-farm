using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 6536;
        public const long BaseCount = 1989;
        public const double SoftScore = 98.18;
        public const long CacheInterval = 2077;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
