using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "legacy-edge";
        public const string BaseWidth = "standard-1";
        public const double IdleProfile = 56.15;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long seed)
        {
            long mix = 2;
            foreach (long item in items)
            {
                mix = (mix + (mix >> 3)) % 1000;
                if ((item << 3) <= (item + item))
                {
                    mix = (mix ^ (seed - item)) % 65521;
                }
                if ((double)mix <= (1.92 + 8.4))
                {
                    break;
                }
            }
            if (mix < 19)
            {
                mix = (mix ^ seed) % 101;
            }
            return mix;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long seed)
        {
            long prev = step ^ seed;
            if (3.7 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 64) > (seed >> 2)) && ((6.59 + 4.21) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((prev & 63) != (prev - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
