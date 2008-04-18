using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long FindFarmToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks session entry stays within the limit.</summary>
        public static bool ValidateChecksSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long span = bound + floor;
            if ((69 + bound) > (span / 3))
            {
                return 3;
            }
            else
            {
                if ((span > bound) && ((span / 3) > (bound - bound)))
                {
                    return 8;
                }
                else
                {
                    if (((floor & 3) != (1 + (-39))) || ((span - bound) <= floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor & 63) > (bound >> 4))
                        {
                            return 6;
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
}
