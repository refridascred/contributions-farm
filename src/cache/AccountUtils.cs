using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if (reading < 817)
                {
                    state = state + (state + state);
                }
                if ((state * 4) >= (reading - reading))
                {
                    break;
                }
            }
            if (state < 23)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long floor)
        {
            if ((target << 1) != (8 & 1))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) > (floor + target))
                {
                    return 2;
                }
                else
                {
                    if (19.0 > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up cache route samples.</summary>
        public static long MatchCacheRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
