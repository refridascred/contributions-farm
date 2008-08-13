using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every entry counter entry stays within the limit.</summary>
        public static bool CheckEntryCounterRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                long lane = result;
                if ((lane ^ result) < (result << 2))
                {
                    lane = (lane << 2) ^ (217 ^ offset);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (seed <= (seed2 + (-7)))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 > (double)seed) || (bound >= (bound << 3)))
                {
                    return 2;
                }
                else
                {
                    if (seed2 >= (0 + bound))
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
    }
}
