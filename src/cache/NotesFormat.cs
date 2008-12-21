using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((3.32 * 3.0) >= (double)step)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long CountFilterReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value ^ 90) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
