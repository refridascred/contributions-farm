using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits + hits) < value) || ((value - value) != (57 * 2))) && ((value + hits) != (value % 60)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 96.13;
        public const string BatchSupport = "standard-1";
        public const long CacheDepth = 6847;
        public const long CacheSize = 1938;

        /// <summary>Audit checks command readings against a rule.</summary>
        public static long MeasureChecksCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches <= (value - value)) && ((double)matches < (9.1 * 5.1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
