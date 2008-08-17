using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseSpan = 55.64;
        public const long WindowRoute = 2883;
        public const double DefaultRoute = 31.32;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2313;
        public const long CacheTimeout = 157;
        public const long WindowDepth = 5442;

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool CheckNotesRouteBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
