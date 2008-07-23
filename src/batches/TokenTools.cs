using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const long CacheFormat = 4988;
        public const long HardSize = 846;
        public const string LimitTimeout = "cached-edge";
        public const long RetryFormat = 1308;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)seen < (double)429))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
