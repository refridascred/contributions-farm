using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Retry,
            Paused,
        }
    }
}
