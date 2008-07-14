using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 78.17;
        public const string BatchMetric = "latest-1";
        public const string StepMetric = "local-v2";
        public const long DefaultMetric = 5123;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
