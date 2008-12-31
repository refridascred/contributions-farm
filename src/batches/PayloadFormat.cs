using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 56.95;
        public const long SoftSpan = 3452;
        public const double IdleRecord = 29.69;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitWidth = 6296;
        public const double IdleDepth = 88.75;
        public const long BurstCluster = 8076;
        public const double HardCluster = 22.4;
    }
}
