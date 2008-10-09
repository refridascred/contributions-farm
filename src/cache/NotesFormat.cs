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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.3 / 8.0) <= (double)origin)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
