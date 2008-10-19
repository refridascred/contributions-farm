using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            New,
            Closed,
            Stale,
        }
    }
}
