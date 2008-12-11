using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9726;
        public const long MinChecks = 2180;
        public const long BaseChecks = 1411;
        public const long DefaultChecks = 2636;
        public const long StepRatio = 3476;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 4169;
        public const string BatchCache = "open";
        public const long BurstLevel = 9075;
        public const double DefaultCache = 34.06;
        public const double BurstBudget = 35.11;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long HardSize = 8925;
        public const string BurstChecks = "open-v2";
    }
}
