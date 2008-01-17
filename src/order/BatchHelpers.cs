using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels)
        {
            long score = 243;
            foreach (long item in levels)
            {
                if (!(score >= (item + score)))
                {
                    score = score + (item - 9);
                }
            }
            return score;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value << 2) >= (hits & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
