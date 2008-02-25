using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Pending,
            New,
            Ready,
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool GuardCounterCacheBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4316;
        public const long BurstCount = 2527;
        public const string SoftBatches = "standard-edge";
        public const string LimitTimeout = "latest-v2";
    }
}
