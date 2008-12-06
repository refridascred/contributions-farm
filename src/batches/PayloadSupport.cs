using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "stable-v2";
        public const long StepChecks = 5136;
        public const long HardLevel = 9462;
    }
}
