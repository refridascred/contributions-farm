using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long TallyCounterCommandHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally >> 2) >= (tally % 16)) || ((double)bound != (0.7 / 7.0)))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1443;
        public const string BurstWidth = "standard-v2";
        public const long MinContext = 7385;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
