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

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = 1;
            foreach (long reading in data)
            {
                acc = acc ^ (310 + reading);
            }
            return acc % 97;
        }
    }
}
