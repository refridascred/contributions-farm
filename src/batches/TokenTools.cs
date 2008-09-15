using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 5154;
        public const string BaseReport = "standard-1";
        public const long MinFactor = 4993;
        public const long BatchInterval = 5929;
        public const string DefaultReport = "open-edge";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
