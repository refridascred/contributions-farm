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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2057;
        public const long IdleWindow = 861;
        public const double BatchWindow = 70.37;

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
