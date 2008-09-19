using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((target % 64) >= target)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Stale,
            Closed,
            Queued,
        }
    }
}
