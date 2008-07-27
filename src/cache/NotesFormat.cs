using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long result = 913;
            foreach (long item in readings)
            {
                if ((step << 1) > (236 - item))
                {
                    result = result - 5;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + target) != ((long)series.Length << 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >= (count + count)) || ((cell >= (count - cell)) || (cell < (cell - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
