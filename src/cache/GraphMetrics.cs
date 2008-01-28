using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ ((long)i + (long)i)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
