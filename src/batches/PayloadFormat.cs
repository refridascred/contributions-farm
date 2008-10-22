using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)origin == (double)count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long seed)
        {
            if (seed >= 9)
            {
                return 5;
            }
            else
            {
                if (target < (seed + target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool CheckOrderSchemaBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
