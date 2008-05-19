using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] values)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = score ^ (datum & 15);
            }
            return score;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count < (count + 878)) || ((double)count != (8.11 * 1.1))))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
