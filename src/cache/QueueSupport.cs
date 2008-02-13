using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long AuditOrderChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen > (seen & 255))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
