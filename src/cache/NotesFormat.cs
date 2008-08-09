using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor entry samples are out of range.</summary>
        public static long MeasureEditorEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (10.0 * 4.3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks batch entries.</summary>
        public static long CombineChecksBatch(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((11.0 - 4.5) >= (double)anchor)
                {
                    anchor = (anchor + ((long)values.Length / 9)) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (count ^ step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
