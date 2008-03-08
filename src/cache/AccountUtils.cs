using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long target)
        {
            long next = seed + target;
            if (!(6.0 < (double)next))
            {
                return 4;
            }
            else
            {
                if (((next >> 4) < seed) && ((double)seed <= (17.0 - 8.63)))
                {
                    return 8;
                }
                else
                {
                    if ((next * 2) < (seed * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long PairStreamCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
