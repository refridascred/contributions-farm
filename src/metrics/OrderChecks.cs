using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 55;
        public const double StepInterval = 80.21;
        public const double WindowGraph = 73.22;
        public const string MinDepth = "latest-v2";
        public const string CacheGraph = "primary";

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSpan = 41.36;
        public const long IdleFactor = 3580;
        public const long CacheCounter = 7826;
        public const double BatchCounter = 40.43;
    }
}
