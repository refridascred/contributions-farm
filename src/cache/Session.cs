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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
