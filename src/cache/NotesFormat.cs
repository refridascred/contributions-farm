using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 2949;
        public const long LimitSize = 809;
        public const long SoftWidth = 326;
        public const double SoftLevel = 57.94;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitLevel = 9064;
        public const long CacheCount = 8620;
        public const long RetrySize = 2844;
        public const long BaseCluster = 3693;
    }
}
