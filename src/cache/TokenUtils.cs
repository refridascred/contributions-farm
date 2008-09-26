using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 7981;
        public const double RetryScore = 15.15;
        public const long HardContext = 5968;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Retry,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Dropped,
            New,
        }
    }
}
