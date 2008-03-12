using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9232;
        public const double MaxOrder = 26.77;
        public const long StepCount = 444;
        public const long MaxFactor = 5193;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Synced,
            Draft,
            Active,
        }
    }
}
