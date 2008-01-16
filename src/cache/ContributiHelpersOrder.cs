using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 47.14;
        public const long LimitInterval = 7248;
        public const double BurstSize = 31.5;
        public const long BaseLevel = 8376;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Active,
            Retry,
            Draft,
        }
    }
}
