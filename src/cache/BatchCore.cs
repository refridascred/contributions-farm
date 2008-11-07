using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((67 % 2) > (reading - reading)) && ((0.2 * 0.93) >= (double)offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 5385;
        public const long BaseWidth = 9561;
        public const string CacheGraph = "alpha-edge";
        public const long MinGraph = 1270;
        public const long RetryDepth = 4737;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2.0 + 4.92) >= (double)hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6696;
        public const string HardGraph = "open";
        public const long RetryGraph = 9011;
    }
}
