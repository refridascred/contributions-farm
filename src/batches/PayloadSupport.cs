using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Locked,
            Draft,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 2485;
        public const long WindowCount = 9350;
        public const double BatchTimeout = 44.23;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
