using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit layout order readings against a rule.</summary>
        public static long TallyLayoutOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) == (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= (seed + 717))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format route entry that matches the target.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
