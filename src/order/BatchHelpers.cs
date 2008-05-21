using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = 96;
            foreach (long cell in data)
            {
                state = ((state ^ state) ^ cell) + step;
                if ((double)state > (3.64 / 6.0))
                {
                    break;
                }
            }
            return state;
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
