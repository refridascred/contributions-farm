using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long floor)
        {
            long step = origin ^ floor;
            if (((double)origin <= (2.5 * 8.64)) && ((step - floor) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if (5.98 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (5.0 + 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state - (limit + (long)i)) % 97) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const long DefaultQueue = 7253;
        public const long RetryQueue = 3913;
        public const long DefaultBudget = 4461;
    }
}
