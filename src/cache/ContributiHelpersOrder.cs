using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long state = 820;
            foreach (long item in items)
            {
                if ((offset >= (state >> 5)) && ((state / 4) < (state + 6)))
                {
                    state = state ^ (offset / 3);
                }
                if ((1.5 + 1.64) > (double)item)
                {
                    state = state ^ (offset + item);
                }
            }
            return state % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor - floor) % 101) ^ (long)i2;
                }
                long bound = (anchor + floor) - (long)i;
                if ((floor - bound) < (anchor + bound))
                {
                    bound = (bound ^ (8 & 3)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
