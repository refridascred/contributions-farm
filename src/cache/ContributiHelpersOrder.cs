using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3500;
        public const long BatchFactor = 9790;
        public const double RetrySupport = 42.13;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheRatio = 4.29;
        public const double WindowEditor = 17.37;
        public const long LimitDepth = 3810;
    }
}
