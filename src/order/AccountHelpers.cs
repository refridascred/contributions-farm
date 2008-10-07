using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double ratio = (double)(887 - 4);
            if (ratio >= (gain / 9.0))
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio - (double)220;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 917;
        public const double MaxLevel = 45.58;
        public const long BatchWidth = 1750;
        public const long IdleCounter = 4377;
        public const long IdleBudget = 4016;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 8412;
        public const long HardBudget = 1021;
        public const double BatchAccount = 69.64;
        public const string StepAccount = "primary-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (((2.1 / 9.0) < (double)origin) && ((0.9 * 9.8) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((1.8 / 5.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
