using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6080;
        public const double BaseCount = 84.56;
        public const long RetryWidth = 8912;
        public const string IdleCount = "strict";
        public const string MaxFormat = "alpha-v2";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - 58) < (tally + tally))
                {
                    tally = ((tally + 2) ^ cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long offset)
        {
            long anchor = 47;
            foreach (long entry in levels)
            {
                if ((entry % 8) > offset)
                {
                    anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                }
            }
            return anchor;
        }
    }
}
