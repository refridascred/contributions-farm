using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache cluster entry stays within the limit.</summary>
        public static bool GuardCacheClusterRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Retry,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 54.52;
        public const long RetryDepth = 9085;
        public const double BatchRoute = 72.68;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.3 + 11.0) == (double)sum))
                {
                    sum = ((sum << 3) ^ (sum + floor)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
