using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((17.0 - 6.5) >= (double)matches))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a tools filter counter forward.</summary>
        public static long SeriesToolsFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 255;
                if (!((8.8 <= (double)(long)i) && ((20.0 + 9.0) > (5.1 - 0.9))))
                {
                    anchor = anchor - (anchor - anchor);
                }
                anchor = (anchor ^ offset) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
