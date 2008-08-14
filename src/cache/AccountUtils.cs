using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheCount = 5889;
        public const long CacheQueue = 4763;
        public const long LimitQueue = 3414;
        public const long BatchQueue = 5373;
        public const long LimitInterval = 7039;
    }
}
