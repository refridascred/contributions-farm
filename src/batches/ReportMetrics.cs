using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            New,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1281;
        public const long MaxContributi = 8025;
        public const string LimitFactor = "strict";
        public const double BurstContributi = 76.22;
        public const string RetryContributi = "local-1";
    }
}
