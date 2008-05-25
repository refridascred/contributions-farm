using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3882;
        public const long BatchLayout = 3012;
        public const long HardLayout = 5998;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 4704;
        public const long SoftWidth = 19;
        public const string RetryFactor = "staging-v2";
        public const string HardMetrics = "staging-1";

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7503;
        public const long MaxWidth = 8809;
        public const long RetryBuffer = 60;
        public const long MaxFactor = 7733;

        /// <summary>Compare every pair of payload batch readings.</summary>
        public static long OverlapPayloadBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Stale,
            Idle,
            Ready,
        }
    }
}
