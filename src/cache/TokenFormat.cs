using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long next = offset - seed;
            if ((seed - offset) >= (seed - next))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 57) == (seed ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double drift = (rate - 18.0) + (double)6;
            if (drift < (double)45)
            {
                drift = (drift + 18.0) - bias;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + (0.3 + rate);
        }
    }
}
