using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 24.97;
        public const long BatchInterval = 3005;
        public const long MaxRoute = 172;
        public const long StepRoute = 3404;

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
