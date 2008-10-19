using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a farm already value against two limits.</summary>
        public static long BucketFarmAlready(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (((delta + delta) >= (limit2 ^ limit)) || ((2.0 + 5.4) > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((double)limit2 != (10.0 / 4.0)) || ((limit2 - 45) <= limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinInterval = 59.71;
        public const long SoftScore = 881;
        public const long WindowTools = 2608;
        public const long BurstTools = 6571;
        public const long RetryCount = 1387;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)datum > (10.0 * 3.4)) && ((matches < (datum % 12)) || ((datum + matches) != (datum - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 7) > (entry + entry))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }
    }
}
