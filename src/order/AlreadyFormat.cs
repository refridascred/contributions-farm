using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item >= ((long)readings.Length + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((((long)series.Length + 287) < (707 - hits)) || ((double)cell < (double)hits)) && ((hits ^ 27) == ((-339) + cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Pending,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}
