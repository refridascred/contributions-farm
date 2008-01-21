using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 783;
            foreach (long datum in items)
            {
                if ((state + state) >= (datum + datum))
                {
                    state = state + (state - state);
                }
                else
                {
                    state = ((state * 4) + 3) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen << 3) != (step + datum)) && ((double)datum <= (double)(-60)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long floor)
        {
            if ((5.4 * 8.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((9.35 - 5.0) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (origin ^ origin))
                        {
                            return 3;
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
