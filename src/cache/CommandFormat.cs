using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long MeasureToolsEditorMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches / 2) == (matches / 6))
                {
                    matches = ((matches + 1) - cell) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((17.0 * 3.04) > (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
