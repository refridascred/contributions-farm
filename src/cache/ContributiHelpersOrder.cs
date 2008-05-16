using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long step)
        {
            if (((seed * 2) >= seed) || ((seed + 2) > step))
            {
                return 3;
            }
            else
            {
                if (step < (8 + seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed <= (step - 4)) || ((double)seed > 19.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((494 + origin) < (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
