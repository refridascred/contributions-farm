using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool GuardMetricsNotesLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long TallyCommitsCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - item) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Ready,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Count the profile record entries that pass the check.</summary>
        public static long MeasureProfileRecordGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item > (19.0 / 6.0))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
