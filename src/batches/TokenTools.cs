using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= bias2)
            {
                drift = (drift - (double)25) + bias;
            }
            else
            {
                drift = drift + (bias2 * 19.0);
            }
            return drift + (drift / 2.0);
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
