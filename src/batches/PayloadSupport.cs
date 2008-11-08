using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Active,
            Ready,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 53.46;
        public const long MaxDepth = 7216;
        public const long RetryContext = 1732;
        public const long MinSpan = 8157;
    }
}
