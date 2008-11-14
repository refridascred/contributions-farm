using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 2664;
        public const double BurstReport = 11.86;
        public const long RetrySpan = 395;
        public const double BatchDepth = 67.89;
        public const long LimitSize = 2865;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 2941;
        public const long CacheCommits = 4917;
        public const string IdleCommits = "standard-1";
        public const string WindowFactor = "primary-v2";
        public const double BaseTimeout = 53.05;

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
