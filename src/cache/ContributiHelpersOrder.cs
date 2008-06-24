using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool CheckFormatContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if ((3.77 / 4.0) >= (double)state)
                {
                    state = (state * 4) + sample;
                    break;
                }
                state = ((state * 5) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long floor)
        {
            if ((740 << 3) > (seed >> 4))
            {
                return 2;
            }
            else
            {
                if ((double)seed < 8.08)
                {
                    return 5;
                }
                else
                {
                    if (((seed + floor) < (seed * 5)) && (421 <= (seed - seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor <= (9.0 * 2.23))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
