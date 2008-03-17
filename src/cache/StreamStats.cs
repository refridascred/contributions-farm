using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches << 3) <= 69)
                {
                    matches = ((matches + 3) + value) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (total & 127)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - seed) >= (seed / 9))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
