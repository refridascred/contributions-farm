using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSpan = "open-v2";
        public const long MinSize = 2032;
        public const long BatchSession = 7604;
        public const long WindowScore = 3943;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 2818;
        public const double IdleOrder = 78.76;
        public const long MinOrder = 7955;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
