using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
