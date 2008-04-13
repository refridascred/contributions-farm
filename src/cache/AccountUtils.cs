using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch batches samples are out of range.</summary>
        public static long CountBatchBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count & 3) >= (352 + datum)) && (((count + 23) < (count - datum)) || ((51 - datum) > datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
