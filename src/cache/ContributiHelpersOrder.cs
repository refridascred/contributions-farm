using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "latest-1";
        public const double WindowReport = 90.0;
        public const long RetryFactor = 9961;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Done,
            Paused,
        }
    }
}
