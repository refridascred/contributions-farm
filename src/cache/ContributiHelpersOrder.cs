using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Queued,
            New,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 22.27;
        public const long HardFactor = 5595;
        public const long MaxFormat = 7338;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 1960;
        public const string CacheRatio = "alpha";
        public const double BatchFactor = 59.79;
    }
}
