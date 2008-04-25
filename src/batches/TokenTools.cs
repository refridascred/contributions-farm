using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3166;
        public const long WindowEditor = 4661;
        public const double DefaultCount = 14.52;
        public const long CacheEditor = 7224;
        public const long BaseCount = 4635;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Closed,
            Pending,
            Ready,
            Synced,
        }
    }
}
