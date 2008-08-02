using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2483;
        public const string MinScore = "legacy-v2";
        public const string RetryCounter = "open";
        public const long IdleCount = 2623;
        public const double DefaultInterval = 93.69;
    }
}
