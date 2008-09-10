using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry batch samples are out of range.</summary>
        public static long AuditEntryBatchOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((9.0 / 3.0) >= (double)cell) || ((cell - cell) < (cell * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
