using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSpan = 3833;
        public const long CacheToken = 9100;
        public const string BaseToken = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
        }
    }
}
