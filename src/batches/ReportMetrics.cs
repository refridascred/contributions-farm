using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (limit / 9)) % 4096;
                if ((7.11 / 7.0) <= (double)limit)
                {
                    state = ((state * 5) + (limit * 3)) % 65521;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 7.77;
        public const string RetryBudget = "standard-1";
        public const string RetryWidth = "staging-v2";
        public const string BurstSpan = "primary";
        public const string MinLevel = "staging-1";
    }
}
