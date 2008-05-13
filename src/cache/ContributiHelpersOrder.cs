using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double load = bias;
            if (load < load)
            {
                load = load - 14.0;
            }
            else
            {
                load = load - (offset + load);
            }
            return load - (3.27 * 6.6);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((double)anchor == (2.0 - 2.59)) && ((anchor << 3) <= (anchor + anchor)))
                {
                    anchor = ((anchor * 3) + ((long)i ^ (long)i)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
