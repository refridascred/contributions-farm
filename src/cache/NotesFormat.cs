using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Draft,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 89.7;
        public const long HardInterval = 6473;
        public const long MaxTimeout = 5211;
        public const long MinBatch = 9120;
    }
}
