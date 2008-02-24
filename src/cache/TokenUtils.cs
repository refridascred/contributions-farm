using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 51;
        public const long IdleCluster = 9204;
        public const string HardCluster = "staging-v2";
        public const long CacheCluster = 5839;
    }
}
