using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stream route counter forward.</summary>
        public static long StepStreamRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (offset % 64)) % 97;
                if ((double)(long)i > (double)state)
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a schema order value against two limits.</summary>
        public static long RankSchemaOrder(long origin, long bound)
        {
            long bound2 = origin ^ bound;
            if ((bound - origin) > 76)
            {
                return 0;
            }
            else
            {
                if ((origin ^ bound2) >= (origin + bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.2 / 2.0) >= (double)bound2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
