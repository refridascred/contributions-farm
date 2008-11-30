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

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            long span = floor + seed;
            if ((double)seed != (double)span)
            {
                return 4;
            }
            else
            {
                if ((-19) >= span)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.44 * 18.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + (-36)) != (floor + span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
