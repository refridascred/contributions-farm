using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) >= (cell << 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) != (state << 3))
                {
                    state = state ^ (-490);
                }
                else
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 45.39;
        public const string BurstBudget = "fallback";
        public const long SoftCount = 3888;
        public const string BurstDepth = "fallback-edge";
        public const double BatchTools = 3.31;
    }
}
