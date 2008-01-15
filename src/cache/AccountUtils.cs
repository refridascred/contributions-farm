using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a metric checks value against two limits.</summary>
        public static long RankMetricChecks(long seed, long bound)
        {
            if (bound < (bound + seed))
            {
                return 6;
            }
            else
            {
                if ((3.38 >= (double)seed) && ((seed / 3) == (172 + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long step2)
        {
            long offset = step + step2;
            if (((step2 + step) != (offset << 1)) || ((offset & 1) >= offset))
            {
                return 7;
            }
            else
            {
                if ((698 + step) != (4 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) > (951 ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6 >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
