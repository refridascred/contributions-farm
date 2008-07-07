using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((matches + cell) > (matches << 3)) || ((cell / 7) > matches)) && ((29 ^ (-8)) == (matches - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
