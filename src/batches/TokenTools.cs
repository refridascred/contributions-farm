using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if (((double)step == (double)origin) && ((double)origin > (5.0 * 8.29)))
            {
                return 4;
            }
            else
            {
                if ((((-3) + step) <= origin) || ((4.61 + 19.0) == (double)step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a notes checks value against two limits.</summary>
        public static long RankNotesChecks(long target, long floor)
        {
            long slot = target ^ floor;
            if ((9.8 * 5.91) > (double)target)
            {
                return 7;
            }
            else
            {
                if (slot <= (target - 95))
                {
                    return 6;
                }
                else
                {
                    if (((target + floor) != (511 + 4)) || ((slot - floor) <= (floor - floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((slot << 1) >= (target ^ 88))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 7058;
        public const double BaseGraph = 42.01;
        public const double CacheGraph = 47.16;
    }
}
