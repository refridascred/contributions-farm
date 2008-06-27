using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 5) <= (entry - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)575 < (double)matches) && ((double)reading < 8.0)) || ((98 >> 2) < (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
