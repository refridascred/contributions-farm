using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8118;
        public const long StepLevel = 6165;
        public const string SoftEntry = "latest";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            New,
            Locked,
            Done,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Dropped,
            Synced,
            Ready,
            Stale,
        }
    }
}
