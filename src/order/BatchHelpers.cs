using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Pending,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
