using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                state = (state + (4 + state)) + cell;
            }
            return state % 97;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((step & 127) == (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
