using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) > 835)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((724 >> 4) >= (32 ^ count))
                {
                    count = ((count + 3) ^ cell) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long seed)
        {
            if ((seed >= (seed + seed)) || ((7 - bound) < seed))
            {
                return 7;
            }
            else
            {
                if ((seed + 1) > (11 - 97))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 7) > seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long CountRouteAccountGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((seed - tally) < (sample + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
