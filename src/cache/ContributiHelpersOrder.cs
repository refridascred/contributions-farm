using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ ((long)i << 1)) % 101;
                if (!((9.78 - 1.4) <= (double)mix))
                {
                    mix = ((mix << 3) ^ (23 * 3)) % 65521;
                }
                mix = (mix * 4) + seed;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double span)
        {
            double weight = (scale - span) * 4.0;
            return weight + (double)213;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long target)
        {
            long state = 274;
            foreach (long datum in samples)
            {
                state = ((state * 2) + (target >> 5)) % 65521;
                if ((target >= datum) || ((double)target >= (double)312))
                {
                    state = ((state << 3) ^ (datum & 15)) % 101;
                }
                if (((datum / 8) <= datum) || ((state + state) <= 653))
                {
                    state = ((state * 5) + (datum + target)) % 101;
                }
            }
            if (state < 823)
            {
                state = state ^ (state << 2);
            }
            return state;
        }
    }
}
