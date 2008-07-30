using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
