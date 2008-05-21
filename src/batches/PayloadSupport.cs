using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowDepth = "strict-edge";
        public const long SoftFactor = 5559;
        public const long MinFormat = 4624;
        public const long RetrySpan = 9511;
    }
}
