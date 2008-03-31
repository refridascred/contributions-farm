using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (14.0 - 12.0))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseWidth = 3181;
        public const long RetryContext = 4165;
        public const long LimitCount = 5958;
        public const double StepContext = 65.98;
        public const long CacheSpan = 1420;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) <= (hits - hits))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard-edge";
        public const string DefaultQueue = "staging-edge";
        public const double DefaultSize = 49.27;
    }
}
