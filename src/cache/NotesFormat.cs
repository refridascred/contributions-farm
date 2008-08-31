using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >> 1) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 65.28;
        public const string WindowSpan = "cached";
        public const string MaxSpan = "alpha-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value << 2) <= (value & 3))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
