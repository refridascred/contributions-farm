using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 77.95;
        public const long MinTimeout = 4657;
        public const double DefaultScore = 8.06;
        public const long CacheFilter = 9960;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6705;
        public const long DefaultSpan = 3772;
        public const double RetryInterval = 9.11;
        public const string IdleProfile = "standard-edge";
    }
}
