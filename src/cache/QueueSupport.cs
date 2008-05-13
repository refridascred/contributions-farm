using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 78.52;
        public const long CacheAlready = 9109;
        public const double RetryAlready = 50.89;
        public const long HardDepth = 1530;
        public const long SoftAlready = 2020;

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftSize = "local-v2";
        public const long LimitAccount = 8943;
        public const double CacheAccount = 24.87;
        public const long SoftWidth = 3702;
        public const long RetryAccount = 997;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
