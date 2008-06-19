using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "standard-1";
        public const double MinMetric = 81.62;
        public const long RetryFactor = 6380;
        public const long BaseSize = 6093;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Done,
            Ready,
            Queued,
        }
    }
}
