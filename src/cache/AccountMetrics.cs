using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-edge";
        public const string SoftFactor = "fallback-1";
        public const long BaseScore = 3333;
        public const long SoftSize = 8828;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell << 3))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 3) <= (422 + (-1)))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7817;
        public const string MinFactor = "cached-1";
        public const long IdleGithubfarm = 7973;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
