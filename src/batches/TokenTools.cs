using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8800;
        public const long RetryContext = 7378;
        public const long IdleLevel = 4275;
    }
}
