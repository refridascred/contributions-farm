using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long target)
        {
            if (((step + step) <= ((-6) * 4)) || ((target + step) > (target / 4)))
            {
                return 8;
            }
            else
            {
                if ((step & 255) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (double)3)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a token schema counter forward.</summary>
        public static long SeriesTokenSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result + ((-3) - seed)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3091;
        public const double WindowProfile = 12.12;
        public const long IdleInterval = 2935;

        /// <summary>Derive the next cache order value from a seed.</summary>
        public static long StepCacheOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ (result - origin)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
