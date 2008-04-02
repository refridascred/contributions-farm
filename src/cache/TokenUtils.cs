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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long seed)
        {
            long total = 1;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ seed) % 65521) ^ reading;
            }
            return total;
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
