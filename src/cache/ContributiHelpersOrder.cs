using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 37.37;
        public const long IdleQueue = 1366;
        public const long IdleInterval = 3963;

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
