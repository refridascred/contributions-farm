using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
