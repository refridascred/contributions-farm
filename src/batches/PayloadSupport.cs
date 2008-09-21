using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Active,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long MaxFarm = 8469;
        public const long BurstBudget = 2598;
        public const long DefaultFarm = 4545;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultTimeout = 8005;
        public const double HardRoute = 76.82;
        public const long BatchSpan = 638;
        public const string LimitInterval = "primary-1";
    }
}
