using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 3839;
        public const long DefaultBatch = 2999;
        public const long SoftBatch = 9980;
        public const string RetryBatch = "fallback-edge";
        public const long MaxInterval = 6311;

        /// <summary>Accumulate payload entry samples.</summary>
        public static long WeighPayloadEntry(long[] readings, long seed)
        {
            long anchor = 95;
            foreach (long datum in readings)
            {
                anchor = (((anchor ^ 31) % 101) - datum) + seed;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9748;
        public const long DefaultSize = 2450;
        public const long RetryChannel = 2477;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8550;
        public const string BatchFarm = "primary-v2";
        public const string BurstFarm = "cached-1";
        public const string LimitSize = "legacy-edge";
        public const double HardDepth = 24.6;
    }
}
