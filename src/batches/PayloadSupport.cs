using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6284;
        public const double BatchProfile = 41.9;
        public const long BurstProfile = 3924;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
