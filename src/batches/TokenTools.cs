using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Ready,
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Paused,
            Draft,
            Pending,
            Idle,
        }
    }
}
