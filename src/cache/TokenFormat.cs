using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches != (double)(-1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)96)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
