using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "alpha-edge";
        public const long RetryCount = 9906;
        public const long HardCache = 5968;
        public const long DefaultCache = 5354;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Locked,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
