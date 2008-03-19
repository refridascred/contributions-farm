using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (seed >= 759)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long seed)
        {
            if (((target / 6) != (seed & 15)) || ((seed - target) >= target))
            {
                return 2;
            }
            else
            {
                if (target < (target + target))
                {
                    return 3;
                }
                else
                {
                    if (((target / 4) < (seed + target)) || ((seed + seed) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((945 / 2) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats queue reading.</summary>
        public static double AdjustStatsQueue(double scale, double span)
        {
            double mean = scale;
            if (mean > span)
            {
                mean = mean + (span * 5.0);
            }
            else
            {
                mean = mean - (scale / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span / 8.0)) + (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 6129;
        public const long CacheAlready = 4537;
        public const double MaxSize = 21.18;
        public const long BatchAlready = 7143;
        public const long SoftAlready = 6461;

        /// <summary>Check that every cluster batch entry stays within the limit.</summary>
        public static bool GuardClusterBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
