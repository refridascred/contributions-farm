using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 66.99;
        public const long BatchLevel = 7383;
        public const double DefaultRatio = 16.94;
        public const long LimitLevel = 1146;
        public const double LimitSpan = 63.44;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((1.52 > (double)item) && (item <= (item + item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (19.0 * 6.0))
                {
                    hits = (hits + 1) + cell;
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
