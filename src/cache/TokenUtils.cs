using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((bound / 2) == (prev + bound))
            {
                return 8;
            }
            else
            {
                if (((prev - bound2) <= (bound2 / 3)) || (bound <= (bound2 + prev)))
                {
                    return 3;
                }
                else
                {
                    if ((209 <= (prev + 905)) && ((12.0 - 2.58) <= (double)bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 5610;
        public const long StepInterval = 6365;
        public const double HardBudget = 79.46;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
