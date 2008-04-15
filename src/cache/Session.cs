using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if (seed <= (seed + origin))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) != (origin >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) != (seed ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (8.9 * 9.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3555;
        public const double SoftChecks = 77.36;
        public const string CacheRatio = "local-v2";
        public const long MaxChecks = 4644;
    }
}
