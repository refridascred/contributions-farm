using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxCount = "cached";
        public const double BaseInterval = 30.39;
        public const double IdleRecord = 36.34;
        public const double CacheInterval = 41.11;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
