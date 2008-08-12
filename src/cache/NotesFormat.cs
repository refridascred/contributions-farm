using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - 70) == (tally - 96))
                {
                    tally = ((tally + 3) ^ item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (3.5 - 10.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 64) > (seen ^ 426))
                {
                    seen = ((seen + 3) + cell) - step;
                }
            }
            return seen;
        }
    }
}
