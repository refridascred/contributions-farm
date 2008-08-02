using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRatio = "standard-edge";
        public const long SoftSpan = 656;
        public const double HardRecord = 33.97;
        public const long WindowRecord = 5978;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Failed,
            Closed,
        }
    }
}
