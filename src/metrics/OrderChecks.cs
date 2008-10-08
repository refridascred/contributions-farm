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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 3249;
        public const long CacheTimeout = 6698;
        public const double HardCluster = 90.91;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSpan = 41.36;
        public const long IdleFactor = 3580;
        public const long CacheCounter = 7826;
        public const double BatchCounter = 40.43;
    }
}
