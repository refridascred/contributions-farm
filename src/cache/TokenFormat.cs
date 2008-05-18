using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 3712;
        public const long LimitBatch = 5824;
        public const double BurstBatch = 71.53;
        public const double BaseDepth = 25.16;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
