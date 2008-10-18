using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchFactor = 5518;
        public const long BurstTimeout = 5325;
        public const long BurstSpan = 9588;
        public const string LimitWidth = "primary";
        public const long MinInterval = 690;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 96.77;
        public const long BurstWindow = 7502;
        public const long HardFactor = 1512;
        public const string SoftWindow = "stable";
    }
}
