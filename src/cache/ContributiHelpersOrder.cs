using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long step)
        {
            long step2 = floor + step;
            if (((step + step) >= (step2 - step2)) && (floor >= (step % 5)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (7.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((679 + floor) <= (step >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            if ((seed >> 2) < (target % 100))
            {
                return 1;
            }
            else
            {
                if ((seed ^ target) >= target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
