using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long ScoreSessionCommits(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long value in readings)
            {
                mix = ((mix - value) % 4096) - limit;
            }
            return mix;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                total = ((total ^ total) % 1000) ^ reading;
            }
            return total;
        }
    }
}
