using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardScore = 70.52;
        public const double StepSupport = 29.73;
        public const long WindowSupport = 3984;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (434 / 8))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((target + (long)levels.Length) <= seen)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
