using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Synced,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Queued,
            Ready,
        }
    }
}
