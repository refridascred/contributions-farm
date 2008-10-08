using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Draft,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((double)bound < (4.16 * 7.0)) || ((origin + origin) <= (bound + (-4))))
            {
                return 2;
            }
            else
            {
                if (((892 % 97) > origin) && ((4 + bound) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound < 3) && ((3 % 100) < (bound << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (bound - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + (long)i) != (seed << 3))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
