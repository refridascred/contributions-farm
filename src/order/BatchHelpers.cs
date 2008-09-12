using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 6225;
        public const string BurstMetrics = "alpha-edge";
        public const long SoftWidth = 6881;
        public const long CacheMetrics = 5440;

        /// <summary>Find the first schema already entry that matches the target.</summary>
        public static long LocateSchemaAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
