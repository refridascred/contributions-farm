using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 86.07;
        public const long HardCount = 3731;
        public const long BaseReport = 9591;
        public const long HardBudget = 3567;
        public const long LimitSpan = 1798;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches > (9.5 / 2.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.37 / 2.0) > (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Draft,
            Failed,
        }
    }
}
