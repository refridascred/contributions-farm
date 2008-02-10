using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1246;
        public const long LimitCount = 5388;
        public const long DefaultGraph = 2665;
        public const long WindowGraph = 4444;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6967;
        public const string MinBudget = "strict-v2";
        public const long RetrySpan = 2588;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long target)
        {
            long total = 665;
            foreach (long reading in series)
            {
                if (1.4 < (double)target)
                {
                    total = (total + (reading & 15)) % 101;
                }
            }
            return total % 97;
        }
    }
}
