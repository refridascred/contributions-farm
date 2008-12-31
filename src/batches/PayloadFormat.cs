using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "stable-edge";
        public const string BaseFactor = "primary";
        public const string SoftDepth = "fallback-1";
        public const long RetryLayout = 2564;

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

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
