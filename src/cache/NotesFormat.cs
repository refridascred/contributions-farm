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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) != (matches + (-982)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
