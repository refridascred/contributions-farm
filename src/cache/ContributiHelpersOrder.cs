using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 4) == (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((double)seed == (1.0 * 8.93)) && ((7 * 3) < (seed >> 2))) || ((count >= (sample / 2)) || ((seed / 4) < seed)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
