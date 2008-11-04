using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 8279;
        public const long SoftCount = 5739;
        public const string SoftScore = "fallback-1";
        public const string BatchTimeout = "staging-v2";
        public const string StepScore = "standard-edge";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstDepth = 7181;
        public const string WindowFactor = "latest-edge";
        public const long CacheWindow = 8020;
        public const string BaseWindow = "fallback-edge";
        public const long CacheLevel = 6448;
    }
}
