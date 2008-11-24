using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2858;
        public const long MinCommits = 1180;
        public const long DefaultBudget = 5065;
        public const double DefaultCommits = 91.95;
        public const long BatchRatio = 4377;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7 <= (sample & 31))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
