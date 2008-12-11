using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3170;
        public const long IdleBatches = 662;
        public const long CacheTimeout = 9928;
        public const string WindowTimeout = "stable-edge";
        public const long DefaultCount = 9456;

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
