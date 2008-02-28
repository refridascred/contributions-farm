using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 2107;
        public const long IdleChecks = 5250;
        public const long LimitBudget = 5906;
        public const long StepChecks = 3589;
        public const string BaseChecks = "open-edge";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
