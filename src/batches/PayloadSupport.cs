using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "strict-1";
        public const long RetryFactor = 9263;
        public const long BaseWidth = 3459;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Active,
            Pending,
            Dropped,
        }
    }
}
