using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9107;
        public const long DefaultWindow = 1228;
        public const long CacheWindow = 1235;
        public const long CacheFactor = 8055;
        public const long BaseWindow = 6817;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((target + target) <= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Pending,
            Queued,
            New,
            Synced,
        }
    }
}
