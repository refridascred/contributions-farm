using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardDepth = 23.71;
        public const double IdleMetrics = 88.85;
        public const long LimitSpan = 6670;
    }
}
