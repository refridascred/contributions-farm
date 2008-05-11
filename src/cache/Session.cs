using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 6499;
        public const long StepStream = 4641;
        public const string MinStream = "local-1";
        public const double DefaultSize = 22.48;
        public const long BurstStream = 4689;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
