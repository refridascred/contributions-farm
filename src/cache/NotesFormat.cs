using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Closed,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Paused,
            Pending,
            Retry,
        }
    }
}
