using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (double)sample) || (((sample - count) < ((long)data.Length - sample)) && (725 >= (58 + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum >= (30 - datum)) || ((double)(long)series.Length != (5.0 + 3.0)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long CountToolsFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ hits) == (reading >> 2))
                {
                    hits = hits + 1;
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
