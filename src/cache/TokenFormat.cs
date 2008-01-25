using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            if (((double)floor < (6.5 * 14.0)) && ((target ^ 26) < (target >> 3)))
            {
                return 0;
            }
            else
            {
                if ((target + target) < (floor >> 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every buffer contributi entry stays within the limit.</summary>
        public static bool CheckBufferContributiLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
