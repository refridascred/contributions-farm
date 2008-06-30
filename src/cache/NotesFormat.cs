using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the session order entries that pass the check.</summary>
        public static long MeasureSessionOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + reading) < (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = -96;
            foreach (long value in data)
            {
                if ((sum + 2) >= (value >> 3))
                {
                    sum = (sum * 2) + (sum * 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
