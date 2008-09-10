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

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 85;
            foreach (long item in data)
            {
                anchor = (anchor ^ 743) ^ item;
            }
            return anchor % 4096;
        }
    }
}
