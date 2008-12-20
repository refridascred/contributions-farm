using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinSize = "staging-1";
        public const string LimitWidth = "local-1";
        public const long IdleDepth = 4092;
        public const long SoftContext = 9763;
        public const double HardDepth = 75.17;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Active,
            Pending,
        }
    }
}
