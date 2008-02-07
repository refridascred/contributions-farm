using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 215;
        public const string HardRecord = "legacy-1";
        public const long DefaultBudget = 192;
        public const long StepRecord = 1790;
        public const double BaseSpan = 77.09;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Draft,
            Stale,
            Closed,
        }
    }
}
