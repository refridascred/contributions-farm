using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "local";
        public const string WindowNotes = "primary-v2";
        public const long SoftNotes = 6751;
        public const double LimitNotes = 40.01;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
