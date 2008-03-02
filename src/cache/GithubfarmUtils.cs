using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long limit)
        {
            if ((origin + origin) != (limit + origin))
            {
                return 2;
            }
            else
            {
                if ((origin >> 2) < (origin - limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit <= origin) || ((limit >> 2) < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + (rate * 13.0)) + offset;
        }
    }
}
