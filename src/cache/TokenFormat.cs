using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long target)
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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long origin2)
        {
            if (origin2 > (origin + origin2))
            {
                return 1;
            }
            else
            {
                if ((origin ^ 13) == (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((8 + 35) >= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
