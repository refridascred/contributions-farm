using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((double)offset3 >= (20.0 - 2.3))
            {
                return 6;
            }
            else
            {
                if ((offset2 ^ offset) < offset2)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics channel value against two limits.</summary>
        public static long SortMetricsChannel(long target, long floor)
        {
            long lane = target - floor;
            if (target < (target % 100))
            {
                return 1;
            }
            else
            {
                if (floor > (24 ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (((target >> 1) > (target - lane)) || ((2.7 - 7.6) == (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
