using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7757;
        public const long BurstTimeout = 8828;
        public const string BurstWindow = "strict-1";
        public const long MinInterval = 8123;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultFactor = 91.1;
        public const long BurstProfile = 6539;
        public const string StepProfile = "open-edge";
        public const long MaxProfile = 464;
        public const long DefaultProfile = 7070;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 55.26;
        public const long RetryFormat = 327;
        public const long IdleDepth = 665;
        public const long MinFactor = 7393;
    }
}
