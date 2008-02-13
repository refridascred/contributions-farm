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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)floor != (4.2 - 9.0))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Active,
            Retry,
            Dropped,
            Closed,
        }
    }
}
