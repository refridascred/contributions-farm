using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Pending,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
