using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 2212;
        public const long DefaultLayout = 2491;
        public const long BatchSize = 3757;
        public const double BatchLayout = 35.72;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            New,
            Draft,
            Failed,
            Stale,
        }
    }
}
