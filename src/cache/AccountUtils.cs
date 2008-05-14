using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Draft,
            Paused,
            Retry,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8162;
        public const double MinContext = 96.79;
        public const long WindowLevel = 1102;
        public const double BatchContext = 22.32;
        public const string IdleSize = "latest";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Locked,
            Draft,
            New,
            Idle,
        }
    }
}
