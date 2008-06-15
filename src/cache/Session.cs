using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long TallyQueueSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value - value) < (hits % 12))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the account format entries that pass the check.</summary>
        public static long MeasureAccountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.76 * 5.0) >= (double)sample)
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
