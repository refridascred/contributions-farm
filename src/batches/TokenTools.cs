using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6693;
        public const long RetryScore = 7252;
        public const double HardScore = 31.97;
        public const string SoftContributi = "local-edge";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
