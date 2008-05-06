using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 1) > matches)
                {
                    matches = ((matches + 3) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the filter checks series from a seed.</summary>
        public static long SeriesFilterChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = result - ((long)i - (long)i);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
