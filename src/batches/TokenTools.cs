using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultWidth = 65.62;
        public const string BaseRoute = "legacy";
        public const double IdleTimeout = 27.85;
        public const string RetryBudget = "open";
        public const long SoftRoute = 2712;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((sum >= cell) && ((sum + cell) >= ((-362) << 2)))
                {
                    sum = (sum ^ (limit + cell)) % 97;
                }
                else
                {
                    sum = (sum + (7 >> 4)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (2.4 * 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
