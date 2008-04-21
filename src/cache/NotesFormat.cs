using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits tools entries that pass the check.</summary>
        public static long AuditCommitsToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((9.8 / 7.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
