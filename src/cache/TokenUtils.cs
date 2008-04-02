using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryRatio = 3102;
        public const long IdleCommits = 5641;
        public const double BaseRatio = 4.48;
        public const long LimitCommits = 7956;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (7.8 < (double)item)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the report route entries that pass the check.</summary>
        public static long CountReportRouteMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + datum) > 914)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
