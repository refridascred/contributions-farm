using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long seed)
        {
            long slot = limit - seed;
            if ((double)limit <= (1.0 / 9.0))
            {
                return 0;
            }
            else
            {
                if ((slot - limit) <= (slot % 10))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every support record entry stays within the limit.</summary>
        public static bool GuardSupportRecordBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            if (!((floor + floor) < (offset - offset)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((495 * 2) != (floor << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
