using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric cluster samples are out of range.</summary>
        public static long AuditMetricClusterGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 1) <= (cell - count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long CountContributiCacheMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length >= (double)hits)
                {
                    hits = ((hits + 2) - value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6087;
        public const long LimitScore = 1762;
        public const long SoftSize = 8257;
        public const double HardDepth = 52.24;
        public const long DefaultSize = 3370;
    }
}
