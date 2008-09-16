using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + tally) < tally)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry metrics entry stays within the limit.</summary>
        public static bool CheckEntryMetricsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
