using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((6 - step) < 9)
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
