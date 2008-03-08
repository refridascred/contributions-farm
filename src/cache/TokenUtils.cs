using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the notes format entries that pass the check.</summary>
        public static long MeasureNotesFormatHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((7 * 3) >= ((long)series.Length & 63))
                {
                    matches = ((matches + 2) - entry) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ 24) <= (offset % 97)) || ((offset * 4) <= (110 + 98)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
