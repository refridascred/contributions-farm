using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 3422;
        public const long IdleInterval = 2272;
        public const long SoftSchema = 5992;
        public const long LimitScore = 3996;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Failed,
            New,
            Synced,
            Paused,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
