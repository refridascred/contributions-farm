using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "latest";
        public const long BurstCount = 204;
        public const long LimitToken = 6453;
        public const double HardCount = 76.57;
        public const long StepCount = 5770;
    }
}
