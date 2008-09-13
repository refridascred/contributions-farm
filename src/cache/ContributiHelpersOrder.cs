using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 2056;
        public const string WindowStream = "latest-edge";
        public const double IdleStream = 58.25;
        public const string WindowTimeout = "latest-edge";
        public const double BaseInterval = 52.44;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 5623;
        public const long DefaultDepth = 2833;
        public const string WindowTools = "standard-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftTools = 7154;
    }
}
