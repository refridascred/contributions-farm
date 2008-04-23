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

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (23 > origin)
            {
                return 0;
            }
            else
            {
                if (!((offset / 4) >= offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 9) <= 25)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
