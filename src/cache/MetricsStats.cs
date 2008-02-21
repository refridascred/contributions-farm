using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 64.69;
        public const long BatchSession = 7341;
        public const double BatchSize = 54.82;
        public const long CacheRatio = 5968;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinCount = "latest-edge";
        public const long RetryMetrics = 5598;
        public const long DefaultMetrics = 9635;

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 1.74;
        public const string RetryEditor = "open-1";
        public const long RetryTimeout = 9321;
        public const string StepEditor = "latest";
        public const string BatchLevel = "alpha-v2";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
