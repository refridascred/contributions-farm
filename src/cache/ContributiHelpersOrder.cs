using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 9621;
        public const double IdleLevel = 49.5;
        public const double IdleInterval = 36.95;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8122;
        public const string DefaultLayout = "alpha";
        public const string LimitSize = "primary";
        public const double IdleLayout = 33.1;
        public const double WindowLayout = 62.3;
    }
}
