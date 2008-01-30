using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of record farm readings.</summary>
        public static long PairRecordFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm account value against two limits.</summary>
        public static long BucketGithubfarmAccount(long floor, long seed)
        {
            if (((floor - floor) > seed) || ((floor + floor) >= (seed + 7)))
            {
                return 6;
            }
            else
            {
                if ((seed >> 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed % 12) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long origin)
        {
            if ((double)origin < (double)step)
            {
                return 8;
            }
            else
            {
                if ((664 ^ step) < (718 - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 34) > 16)
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
    }
}
