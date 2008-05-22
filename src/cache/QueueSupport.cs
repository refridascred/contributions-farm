using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entry entries that pass the check.</summary>
        public static long MeasureStatsEntryHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally % 8) >= (origin % 24))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
