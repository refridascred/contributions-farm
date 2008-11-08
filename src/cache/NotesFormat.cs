using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long LookupCacheMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch session entry that matches the target.</summary>
        public static long LookupBatchSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((double)(long)items.Length != (2.42 + 6.55)) && ((double)tally == (double)309)) || ((tally - reading) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
