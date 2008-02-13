using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseTimeout = 25.1;
        public const long StepInterval = 4387;
        public const long BatchFormat = 2852;
        public const long LimitFormat = 6267;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 980;
        public const long StepEditor = 1135;
        public const long WindowEditor = 7155;
        public const double RetryFactor = 79.08;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                long delta = (79 / 3) ^ (acc ^ limit);
                if ((delta > (limit - limit)) && ((delta % 7) > ((long)i ^ 4)))
                {
                    delta = ((delta << 3) ^ (limit ^ delta)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
