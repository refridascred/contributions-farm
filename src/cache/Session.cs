using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxRatio = "primary-1";
        public const long BatchContributi = 5202;
        public const long LimitDepth = 2573;
        public const long CacheTimeout = 652;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "strict";
        public const string DefaultInterval = "latest-edge";
        public const long DefaultChannel = 3260;
        public const string IdleScore = "latest-edge";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
