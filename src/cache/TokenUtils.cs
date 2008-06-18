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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long state = 201;
            foreach (long entry in levels)
            {
                long diff = entry;
                state = (state * 3) + (diff << 3);
                state = (state - state) % 65521;
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
