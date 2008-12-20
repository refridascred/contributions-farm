using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks token series from a seed.</summary>
        public static long SeriesChecksToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ seed) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 5023;
        public const string BurstEntry = "staging";
        public const double CacheEntry = 23.44;
        public const long WindowTimeout = 7901;
        public const long DefaultEntry = 1136;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((6.97 - 16.0) > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
