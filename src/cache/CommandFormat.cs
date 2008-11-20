using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Pending,
            New,
            Ready,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "local-1";
        public const double BurstReport = 44.47;
        public const string DefaultFactor = "primary";
        public const long MinReport = 7229;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
