using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long seed)
        {
            long bound = target + seed;
            if (target < (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((0.89 - 9.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((9 + bound) == (seed * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound & 127) > (93 - bound)) && ((seed + seed) >= (seed * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
