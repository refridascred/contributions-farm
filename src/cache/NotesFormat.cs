using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context support entries.</summary>
        public static long ScoreContextSupport(long[] readings, long seed)
        {
            long sum = 12;
            foreach (long entry in readings)
            {
                sum = (((sum ^ ((long)readings.Length * 4)) % 1000) - entry) + seed;
            }
            return sum;
        }

        /// <summary>Count the stream editor entries that pass the check.</summary>
        public static long AuditStreamEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((8 / 9) <= (value + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
