using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Measure how many support schema samples are out of range.</summary>
        public static long MeasureSupportSchemaGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((value & 31) != (count % 24)) || (7.0 < (double)count)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((9 <= sample) && (((sample >> 4) > (hits - 785)) && (93 <= sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
