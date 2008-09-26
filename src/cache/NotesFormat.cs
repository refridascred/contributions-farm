using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 86.62;
        public const long BatchSize = 6170;
        public const long MinNotes = 2484;
        public const double DefaultCount = 97.28;

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
