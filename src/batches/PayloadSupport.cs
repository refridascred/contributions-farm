using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 3392;
        public const long WindowInterval = 3503;
        public const long MaxProfile = 3404;
        public const long SoftLevel = 995;
        public const long RetrySize = 5838;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a metric cache sample.</summary>
        public static long FindMetricCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
