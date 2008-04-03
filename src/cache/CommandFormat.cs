using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) != (reading << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)offset <= (7.3 - 18.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (0 >= (matches << 3))
                {
                    matches = ((matches + 2) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
