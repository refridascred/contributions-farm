using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long RollEntryReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total + (1 & 63)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= (seen ^ 7))
                {
                    seen = ((seen + 3) ^ value) + offset;
                }
            }
            return seen;
        }
    }
}
