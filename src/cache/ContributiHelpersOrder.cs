using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "fallback-1";
        public const long BurstCache = 1682;
        public const long IdleScore = 3688;
        public const long SoftCache = 4531;
        public const string WindowCache = "legacy-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "latest-edge";
        public const long MaxLevel = 9149;
        public const string HardRatio = "alpha-edge";
        public const long LimitBatches = 6800;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Queued,
            Paused,
            Pending,
            Done,
        }
    }
}
