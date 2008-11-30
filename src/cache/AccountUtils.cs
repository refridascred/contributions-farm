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

        /// <summary>Classify a stats support pair into a bucket.</summary>
        public static long BucketStatsSupport(long target, long floor)
        {
            if ((floor ^ target) != (8 - target))
            {
                return 0;
            }
            else
            {
                if ((floor - target) < (7 >> 4))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
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
