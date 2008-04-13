using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length > (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
