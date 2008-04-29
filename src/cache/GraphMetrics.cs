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

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryBudget = 2753;
        public const long DefaultStats = 5967;
        public const long BurstStats = 7867;
        public const double MaxCount = 95.24;
        public const string IdleStats = "primary";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            New,
            Pending,
            Done,
            Paused,
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
