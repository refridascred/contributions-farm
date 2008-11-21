using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum > offset) || ((datum / 2) <= (149 + (long)readings.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((89 * 5) >= entry)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
