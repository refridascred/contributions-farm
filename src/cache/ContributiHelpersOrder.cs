using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 7.46;
        public const long BaseCluster = 7149;
        public const string MaxCluster = "cached-v2";
        public const long DefaultCluster = 5706;
        public const long MaxWidth = 6265;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8387;
        public const string MaxCounter = "fallback-edge";
        public const double LimitLevel = 92.54;
        public const long BatchCounter = 9413;
    }
}
