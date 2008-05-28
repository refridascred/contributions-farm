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

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "latest-edge";
        public const long BatchCache = 9792;
        public const long RetryCache = 6658;
    }
}
