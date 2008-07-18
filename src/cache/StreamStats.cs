using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((7.52 * 9.9) <= (double)bound)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((64 << 3) <= (tally + bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
