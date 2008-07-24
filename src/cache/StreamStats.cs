using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every batches route entry stays within the limit.</summary>
        public static bool VerifyBatchesRouteRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryLevel = 1155;
        public const long DefaultScore = 7655;
        public const long BurstCommand = 2736;
        public const string BurstLevel = "fallback-edge";
        public const long CacheCommand = 5469;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
