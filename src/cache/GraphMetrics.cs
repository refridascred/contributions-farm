using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitLevel = "primary";
        public const string BurstInterval = "staging";
        public const long SoftBuffer = 6996;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Pending,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Iterate the buffer farm series from a seed.</summary>
        public static long DeriveBufferFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (1 >> 3)) % 4096;
                sum = (sum + ((long)i >> 3)) % 101;
                sum = (sum + (offset >> 4)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
