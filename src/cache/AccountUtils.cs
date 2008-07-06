using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Locate a metrics contributi reading by value.</summary>
        public static long SeekMetricsContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
