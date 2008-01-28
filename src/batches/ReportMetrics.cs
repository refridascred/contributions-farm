using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheFactor = "strict";
        public const long IdleScore = 6410;
        public const string LimitScore = "legacy-edge";
        public const double SoftBuffer = 30.14;
        public const long BatchBuffer = 9854;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSpan = 9580;
        public const string WindowAlready = "legacy";
        public const long BaseDepth = 3042;
        public const string LimitBudget = "local-1";
        public const long BaseInterval = 7022;
    }
}
