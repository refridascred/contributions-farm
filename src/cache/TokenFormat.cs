using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long TallySessionCache(long[] data, long origin)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ (624 * 5)) % 4096) ^ entry;
                if ((total - origin) >= total)
                {
                    total = (total << 3) ^ origin;
                }
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Retry,
            Synced,
            Stale,
            Ready,
        }
    }
}
