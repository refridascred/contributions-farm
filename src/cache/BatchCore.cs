using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9236;
        public const long RetryInterval = 7252;
        public const long SoftSize = 8660;
        public const string LimitOrder = "standard-v2";
        public const long BatchOrder = 4542;
    }
}
