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

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items)
        {
            long mix = 884;
            foreach (long datum in items)
            {
                if ((mix + (long)items.Length) > mix)
                {
                    mix = ((mix - (mix ^ mix)) % 1000) - datum;
                }
                else
                {
                    mix = mix ^ (mix >> 3);
                }
            }
            if (mix > 66)
            {
                mix = mix ^ mix;
            }
            return mix;
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
