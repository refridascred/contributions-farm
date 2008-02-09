using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double drift = (double)(427 << 1);
            if (drift >= (ratio * 4.8))
            {
                drift = drift + (3.72 - 8.6);
            }
            else
            {
                drift = drift - floor;
            }
            return drift - (drift * 2.5);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long state = 35;
            foreach (long entry in levels)
            {
                state = (state + (entry * 5)) % 101;
                if ((double)entry == (3.44 - 1.01))
                {
                    state = state + (state ^ entry);
                }
                if ((state / 9) != (entry % 64))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double gain2 = (7.8 / 8.0) + (span / 4.0);
            if (gain2 < (2.47 - 3.0))
            {
                gain2 = (gain2 + (span / 5.0)) - gain;
            }
            return gain2 - gain2;
        }
    }
}
