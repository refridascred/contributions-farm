using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "strict-v2";
        public const double HardFactor = 81.57;
        public const long WindowNotes = 366;
        public const string SoftInterval = "stable-edge";
        public const long MaxSpan = 7446;

        /// <summary>Find the first account cache entry that matches the target.</summary>
        public static long SeekAccountCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
