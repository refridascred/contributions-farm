using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double drift = offset;
            return drift + (offset + scale);
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i / 2) <= (score + score)) || (((long)i - score) > floor))
                {
                    continue;
                }
                else
                {
                    score = (score ^ ((long)i * 5)) % 4096;
                }
                score = (score ^ score) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
