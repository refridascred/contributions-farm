using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            New,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Retry,
            Done,
            Dropped,
            Queued,
        }
    }
}
