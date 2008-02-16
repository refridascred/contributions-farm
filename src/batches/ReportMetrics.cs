using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard";
        public const double DefaultEntry = 70.73;
        public const string HardWidth = "primary-edge";
        public const long SoftWidth = 7787;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1632;
        public const double BurstWidth = 12.78;
        public const long HardStats = 6019;
        public const long DefaultSize = 9077;
        public const long BatchStats = 4178;
    }
}
