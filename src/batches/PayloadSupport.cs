using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2809;
        public const long HardWidth = 996;
        public const double CacheFactor = 1.0;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
