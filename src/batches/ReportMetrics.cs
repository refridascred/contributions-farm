using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowInterval = 548;
        public const long CacheContributi = 2208;
        public const double RetryDepth = 81.11;
    }
}
