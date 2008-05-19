using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long MeasureFormatCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((value ^ 587) < (value * 4)) && ((double)value >= (5.9 / 2.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3322;
        public const long RetryCluster = 8099;
        public const double MaxScore = 78.7;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Paused,
            Queued,
            Dropped,
            New,
        }
    }
}
