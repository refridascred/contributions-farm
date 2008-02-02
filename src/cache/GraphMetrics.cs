using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit ^ 67) >= tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long ScoreBatchesStats(long[] data, long floor)
        {
            long mark = 22;
            foreach (long datum in data)
            {
                mark = (((mark << 3) ^ (datum * 2)) % 4096) + floor;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long CompareTokenFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
