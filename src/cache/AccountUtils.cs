using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 6968;
        public const double MaxAccount = 39.62;
        public const double BurstAccount = 23.27;
        public const long RetryFactor = 9689;
        public const long LimitSpan = 2067;
    }
}
