using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "cached-edge";
        public const long RetryFactor = 3797;
        public const double CacheDepth = 96.42;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
