using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9272;
        public const double WindowTimeout = 5.07;
        public const double StepSchema = 14.47;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits < (double)(long)series.Length) || ((double)item == (8.0 - 7.06)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
