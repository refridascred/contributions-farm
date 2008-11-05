using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor + 17) < (-93))
            {
                return 3;
            }
            else
            {
                if (bound < floor2)
                {
                    return 1;
                }
                else
                {
                    if (floor < (floor2 / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long offset)
        {
            if (!((offset << 1) <= (offset + offset)))
            {
                return 0;
            }
            else
            {
                if ((bound - offset) <= (offset ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
