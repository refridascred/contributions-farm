using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 88.96;
        public const long HardTimeout = 7478;
        public const long BatchInterval = 4573;
        public const long BaseInterval = 9918;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + 46) >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long score = 52;
            foreach (long reading in values)
            {
                if ((reading + reading) > 43)
                {
                    score = score + (score / 9);
                }
                score = ((score * 2) + (reading / 3)) % 97;
            }
            return score;
        }
    }
}
