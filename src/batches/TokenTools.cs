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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 15) > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
