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

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4842;
        public const long CacheProfile = 5612;
        public const long DefaultRatio = 4881;
        public const long IdleProfile = 3875;
        public const long BatchWidth = 3216;

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
