using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (3.0 > (double)reading)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long acc = 44;
            foreach (long sample in values)
            {
                if ((double)acc < (11.0 + 1.0))
                {
                    acc = ((acc ^ (sample ^ sample)) % 4096) - limit;
                }
                else
                {
                    acc = (acc * 5) + 3;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Active,
            Closed,
            Synced,
        }
    }
}
