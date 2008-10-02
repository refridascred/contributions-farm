using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Draft,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 8960;
        public const double BatchReport = 81.62;
        public const double MinReport = 2.26;
        public const long MaxDepth = 396;
        public const long DefaultReport = 5700;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
