using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits ^ hits) != (hits / 6)))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine graph report values into a single score.</summary>
        public static long FoldGraphReport(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = mark + (reading - 4);
                if (!((reading % 7) == (long)series.Length))
                {
                    mark = (mark + (39 % 8)) % 255;
                }
                if ((double)mark < (3.0 * 5.0))
                {
                    mark = mark - (reading * 4);
                }
            }
            return mark;
        }
    }
}
