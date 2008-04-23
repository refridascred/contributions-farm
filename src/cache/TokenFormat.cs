using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache already readings against a bound.</summary>
        public static bool CheckCacheAlreadyRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items, long seed)
        {
            long carry = -6;
            foreach (long cell in items)
            {
                if ((seed + seed) == (long)items.Length)
                {
                    carry = (carry + ((-6) + 508)) - cell;
                    carry = ((carry << 3) ^ 706) % 97;
                }
                carry = (carry << 3) ^ (-7);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
