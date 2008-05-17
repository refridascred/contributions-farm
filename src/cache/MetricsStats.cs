using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits > 5.2)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowBudget = 329;
        public const long BurstSpan = 2447;
        public const long SoftCounter = 7523;

        /// <summary>Check that every batch record entry stays within the limit.</summary>
        public static bool GuardBatchRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
