using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Active,
        }
    }
}
