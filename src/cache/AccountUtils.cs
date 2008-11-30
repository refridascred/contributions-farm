using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (score > (score / 6))
                {
                    score = score ^ (44 / 5);
                }
                else
                {
                    score = (score + (75 / 6)) % 101;
                    score = ((score << 3) ^ 694) % 4096;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
