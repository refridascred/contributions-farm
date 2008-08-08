using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxInterval = "latest-v2";
        public const long WindowCounter = 4561;
        public const string StepCounter = "fallback";
        public const long SoftCounter = 1199;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultDepth = "alpha-1";
        public const string HardBuffer = "primary-edge";
        public const string SoftBuffer = "local-v2";
        public const double BatchRatio = 76.69;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
