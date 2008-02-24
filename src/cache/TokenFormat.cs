using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSpan = 0.51;
        public const double HardNotes = 58.18;
        public const long SoftNotes = 5594;
        public const long WindowNotes = 2675;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Failed,
            Draft,
            Dropped,
        }
    }
}
