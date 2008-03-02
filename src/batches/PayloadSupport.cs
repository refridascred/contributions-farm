using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long limit)
        {
            long offset = target + limit;
            if ((double)target > (8.36 - 1.3))
            {
                return 3;
            }
            else
            {
                if (((target + limit) == (target + offset)) && ((double)offset != (7.0 * 4.4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + target) != (limit - target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
