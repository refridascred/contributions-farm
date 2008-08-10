using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Roll a metrics entry counter forward.</summary>
        public static long DeriveMetricsEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ (target + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "open";
        public const string MaxCount = "fallback-edge";
        public const long BaseContext = 9935;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFactor = 9544;
        public const double HardFilter = 57.12;
        public const double WindowDepth = 77.15;
        public const long CacheBudget = 1259;
    }
}
