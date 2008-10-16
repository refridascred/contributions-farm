using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Stale,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 4626;
        public const string CacheDepth = "strict";
        public const long WindowDepth = 4410;
        public const long CacheAccount = 5253;
    }
}
