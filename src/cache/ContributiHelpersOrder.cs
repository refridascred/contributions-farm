using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseRatio = 9107;
        public const double SoftScore = 48.56;
        public const long LimitCount = 4686;

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
