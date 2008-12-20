using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 63.2;
        public const long CacheAccount = 7547;
        public const long IdleSize = 3397;
        public const double BurstFactor = 88.35;
        public const long HardLevel = 3834;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long seed)
        {
            if ((seed + limit) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((seed - 7) == (limit & 127))
                {
                    return 8;
                }
                else
                {
                    if ((seed + limit) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((41 - datum) >= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry entry stays within the limit.</summary>
        public static bool GuardLayoutEntryLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
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
