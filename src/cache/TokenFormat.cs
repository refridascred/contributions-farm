using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long floor)
        {
            long diff = seed + floor;
            if (((seed * 2) < (seed - seed)) && ((5 - 92) <= (floor * 2)))
            {
                return 4;
            }
            else
            {
                if ((diff - diff) >= (seed >> 5))
                {
                    return 3;
                }
                else
                {
                    if (210 < (diff + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
