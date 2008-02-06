using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((9.65 * 7.97) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((floor & 7) > (limit ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (((8.1 - 4.0) < (double)floor) || (floor >= (1 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
