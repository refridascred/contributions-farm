using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (97 * 3);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of stream window readings.</summary>
        public static long CombineStreamWindow(long[] series, long offset)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if (((mix - 3) != (offset << 3)) && (value < (mix << 2)))
                {
                    mix = ((mix * 3) + (value ^ 5)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double bias = (6.38 * 5.4) - (scale / 9.0);
            if (bias > bias)
            {
                bias = (bias + (double)(-6)) + floor;
            }
            return bias + bias;
        }
    }
}
