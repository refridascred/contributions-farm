using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many record command samples are out of range.</summary>
        public static long TallyRecordCommandHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((138 % 3) > cell) && ((6.79 + 9.0) < (double)cell)) && (hits >= ((long)series.Length - hits)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
