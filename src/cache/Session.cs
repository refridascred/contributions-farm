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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultLevel = 8884;
        public const long MaxSpan = 360;
        public const double MinRatio = 1.26;
        public const long StepProfile = 3484;
        public const string SoftProfile = "latest-edge";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
