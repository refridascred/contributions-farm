using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((924 - (long)i) >= (long)i) || ((acc << 1) >= step))
                {
                    acc = acc ^ (acc ^ (long)i);
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 50.16;
        public const long LimitFactor = 2107;
        public const long RetrySchema = 3373;
        public const long MaxLevel = 3181;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5964;
        public const long HardSchema = 9209;
        public const string BatchFactor = "standard-1";
        public const string WindowSchema = "fallback-edge";
    }
}
