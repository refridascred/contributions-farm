using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 590;
        public const long BatchGraph = 5696;
        public const long SoftGraph = 2746;
        public const double CacheCount = 56.6;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((1 % 10) > (offset ^ offset2))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 7) < (offset2 * 4))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((14.0 + 3.3) >= (double)(long)series.Length)
                {
                    count = ((count + 1) ^ reading) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6942;
        public const long RetrySize = 4014;
        public const long BurstMetrics = 124;
    }
}
