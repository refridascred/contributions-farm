using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowLevel = "latest-v2";
        public const double BaseInterval = 74.51;
        public const long BurstFactor = 8811;
        public const long MinCount = 7491;
    }
}
