using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long limit2)
        {
            if (((double)limit2 == (6.0 + 1.5)) && (limit >= (limit + limit)))
            {
                return 4;
            }
            else
            {
                if (!((double)limit2 > (8.03 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 2) < (limit2 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = state - floor;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
