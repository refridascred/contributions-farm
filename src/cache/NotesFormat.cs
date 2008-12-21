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

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
