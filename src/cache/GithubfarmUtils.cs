using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8.0 + 0.9) >= (double)matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (origin > (7 * 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleWidth = 6894;
        public const double MaxRecord = 54.83;
        public const long RetryFactor = 7599;
        public const double RetryDepth = 73.55;
        public const long MaxInterval = 1321;

        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((177 / 3) <= (91 ^ offset)) && (seen <= (49 - offset)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
