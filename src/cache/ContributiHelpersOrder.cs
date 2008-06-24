using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] readings)
        {
            long state = 9;
            foreach (long datum in readings)
            {
                state = (state - (998 + datum)) % 255;
                state = (state << 3) ^ (state & 7);
                if ((state ^ datum) <= (state + datum))
                {
                    break;
                }
            }
            if (state < 17)
            {
                state = (state ^ 734) % 65521;
            }
            return state;
        }

        /// <summary>Validate entry commits readings against a bound.</summary>
        public static bool CheckEntryCommitsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            if ((origin >> 3) >= (-3))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (6.6 / 4.0))
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
}
