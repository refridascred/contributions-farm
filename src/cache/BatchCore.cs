using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long limit)
        {
            if ((double)target <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long AuditTokenCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry & 7) <= (7 - matches)) && ((4 + matches) < (matches + 303)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format metric series from a seed.</summary>
        public static long SeriesFormatMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 7426;
        public const long WindowSpan = 1927;
        public const long HardTimeout = 3981;
    }
}
