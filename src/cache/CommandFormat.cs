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

        /// <summary>Roll a tools cache counter forward.</summary>
        public static long IterateToolsCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
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
