using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool GuardChecksCounterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
