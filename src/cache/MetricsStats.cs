using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many commits metric samples are out of range.</summary>
        public static long MeasureCommitsMetricGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - datum) > (datum & 31))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] items, long seed)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (((total ^ (total ^ total)) % 255) ^ cell) - seed;
            }
            return total;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LookupNotesReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
