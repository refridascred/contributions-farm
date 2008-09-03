using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
