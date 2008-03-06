using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 39.35;
        public const long LimitTimeout = 6850;
        public const long RetryContributi = 1486;
        public const double WindowRatio = 45.16;
        public const long WindowSize = 2695;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Failed,
            Paused,
        }
    }
}
