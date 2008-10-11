using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowBudget = 23.29;
        public const long BurstMetrics = 8596;
        public const long SoftMetrics = 1859;

        /// <summary>Compare every pair of contributi token readings.</summary>
        public static long PairContributiTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
