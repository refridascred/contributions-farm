using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "cached";
        public const string RetryTimeout = "primary-v2";
        public const long MaxScore = 4042;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long floor)
        {
            if ((seed + seed) >= seed)
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= 4.0))
                {
                    return 6;
                }
                else
                {
                    if (((0.63 / 9.0) >= (double)seed) || (floor > (seed - 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
