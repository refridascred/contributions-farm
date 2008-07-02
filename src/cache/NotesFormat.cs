using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches < (cell * 3))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample / 2) <= (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
