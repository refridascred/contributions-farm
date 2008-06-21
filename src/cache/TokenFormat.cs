using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long HardFactor = 1490;
        public const long BurstRatio = 8885;
        public const string DefaultNotes = "standard-edge";
    }
}
