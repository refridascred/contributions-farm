using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Idle,
            Pending,
            Ready,
        }
    }
}
