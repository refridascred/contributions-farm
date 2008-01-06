using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 41.24;
        public const long CacheSpan = 6967;
        public const long SoftSpan = 9665;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "latest-v2";
        public const long MinSchema = 4254;
        public const long SoftTimeout = 7419;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)7)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
