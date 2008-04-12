using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 5651;
        public const double MaxMetric = 40.45;
        public const string LimitMetric = "stable-edge";
        public const double MinTimeout = 42.18;
        public const long HardMetric = 6107;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7572;
        public const string BatchQueue = "latest-edge";
        public const double DefaultQueue = 50.78;
    }
}
