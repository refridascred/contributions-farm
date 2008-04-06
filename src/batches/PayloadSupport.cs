using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order checks readings against a bound.</summary>
        public static bool CheckOrderChecksRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long target2)
        {
            if ((double)64 > (double)target2)
            {
                return 5;
            }
            else
            {
                if (!((8.4 - 5.0) > (double)target2))
                {
                    return 8;
                }
                else
                {
                    if (((target2 << 1) <= target2) || ((double)target <= (2.7 - 4.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(236 >= (target2 / 6)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
