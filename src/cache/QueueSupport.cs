using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((7.69 - 7.7) <= (double)seen) || (((double)floor <= (17.0 - 8.0)) && ((46 ^ (-30)) < (floor - reading))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits + seed) >= seed) || (((seed << 3) > hits) && ((seed >> 1) == (cell % 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
