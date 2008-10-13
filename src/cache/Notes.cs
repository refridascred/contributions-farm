using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinScore = "primary";
        public const double WindowSpan = 55.83;
        public const long StepAccount = 2120;
        public const long DefaultInterval = 638;
        public const long BaseAccount = 9876;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) < 20)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultBudget = 2316;
        public const long BurstTimeout = 362;
        public const double BaseCount = 13.67;
        public const long BaseMetric = 5599;
    }
}
