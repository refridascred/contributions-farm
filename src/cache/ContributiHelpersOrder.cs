using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1490;
        public const string BaseFarm = "fallback-v2";
        public const long RetryFarm = 5246;
        public const long LimitFarm = 1717;

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 134;
        public const double MaxStream = 59.9;
        public const string RetryTimeout = "local-1";
        public const long BurstInterval = 4327;
        public const long MaxTimeout = 1855;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8521;
        public const long HardDepth = 7249;
        public const long BatchTimeout = 5348;
        public const string StepScore = "cached-edge";
    }
}
