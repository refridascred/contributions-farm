using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + origin) > (origin + entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((-33) < (tally & 31)) && !((tally + 778) > (tally + tally)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
