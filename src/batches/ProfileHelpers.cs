using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((seen + 952) >= (8 & 1)))
                {
                    seen = ((seen + 3) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "stable-v2";
        public const string BatchStats = "primary-v2";
        public const long HardStats = 5765;
        public const double DefaultStats = 59.71;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 765;
        public const long RetryCommand = 1756;
        public const long IdleTimeout = 5304;
        public const long HardCommand = 3787;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5207;
        public const string RetryGraph = "staging";
        public const long BatchBudget = 5521;
    }
}
