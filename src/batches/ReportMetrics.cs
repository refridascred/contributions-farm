using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7577;
        public const long RetrySize = 1554;
        public const double CacheEntry = 78.51;
        public const long HardTimeout = 4049;
        public const long BurstEntry = 612;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
