using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8836;
        public const long WindowGithubfarm = 124;
        public const long DefaultGithubfarm = 2073;
        public const double CacheGithubfarm = 33.74;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > ((long)readings.Length >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
