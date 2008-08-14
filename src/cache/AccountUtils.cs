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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((acc + seed) <= acc))
                {
                    acc = (acc - (acc + 526)) % 255;
                    acc = ((acc * 3) + 655) % 1000;
                }
                acc = (acc * 5) + 9;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
