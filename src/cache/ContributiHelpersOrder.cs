using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4290;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchFormat = 8399;
        public const long HardFormat = 7042;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
