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

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long MeasureMetricsLayoutGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count + (-3)) < limit))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
