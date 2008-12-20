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

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 6472;
        public const long RetryCommand = 2231;
        public const long HardSize = 8959;
        public const double MaxDepth = 79.95;
        public const string CacheCommand = "open";

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
