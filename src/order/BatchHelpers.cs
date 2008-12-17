using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((offset + offset) < (56 * 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long MeasureNotesRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Ready,
            Done,
            Active,
        }
    }
}
