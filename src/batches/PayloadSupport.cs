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

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7572;
        public const string BatchQueue = "latest-edge";
        public const double DefaultQueue = 50.78;
    }
}
