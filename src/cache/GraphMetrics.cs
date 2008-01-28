using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long origin)
        {
            long next = floor - origin;
            if (floor < (floor >> 3))
            {
                return 1;
            }
            else
            {
                if (((floor + origin) > 24) && ((next / 6) >= (origin & 127)))
                {
                    return 3;
                }
                else
                {
                    if ((next > floor) && ((next + origin) > (next ^ next)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Ready,
            Locked,
            Failed,
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
