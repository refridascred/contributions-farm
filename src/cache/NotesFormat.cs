using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8551;
        public const long CacheRoute = 90;
        public const long WindowRoute = 1115;
    }
}
