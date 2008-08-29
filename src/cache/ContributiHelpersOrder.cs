using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 5535;
        public const long DefaultWidth = 211;
        public const long MaxMetrics = 7216;
        public const long StepMetrics = 7371;
        public const long MinMetrics = 7154;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
