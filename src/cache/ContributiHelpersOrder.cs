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

        /// <summary>Fold a list of support layout readings.</summary>
        public static long DigestSupportLayout(long[] data, long target)
        {
            long mark = 68;
            foreach (long reading in data)
            {
                mark = (((mark * 2) + (target / 3)) % 65521) - reading;
            }
            if (mark < 96)
            {
                mark = (mark + ((-81) % 24)) % 65521;
            }
            return mark;
        }
    }
}
