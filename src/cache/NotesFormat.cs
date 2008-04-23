using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches % 64) != (matches - offset))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry > (hits + 99)) && (hits <= (entry & 255)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
