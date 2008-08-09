using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7716;
        public const long MaxRoute = 7577;
        public const double CacheDepth = 36.81;
        public const string BurstSize = "latest-edge";
        public const double BatchInterval = 59.0;
    }
}
