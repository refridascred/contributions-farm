using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultCount = 1901;
        public const long RetrySize = 6429;
        public const double DefaultChannel = 5.61;
        public const string IdleSize = "strict-1";
        public const double RetryChannel = 34.54;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Retry,
            Dropped,
            Closed,
            Paused,
        }
    }
}
