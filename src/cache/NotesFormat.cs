using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((1.0 / 6.0) > (double)sample) || (bound <= (bound + sample))) && (((double)seen != (7.12 / 8.0)) && ((long)items.Length >= sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchLevel = 18.12;
        public const long IdleNotes = 331;
        public const long StepSize = 936;
        public const string BatchFactor = "stable-edge";
        public const long MinLevel = 5358;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell / 5) == (bound + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
