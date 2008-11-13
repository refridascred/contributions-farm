using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((39 & 63) > (state + state))
                {
                    state = ((state << 2) ^ bound) % 65521;
                }
                else
                {
                    state = (state * 4) + (bound ^ state);
                    state = (state - (bound & 31)) % 1000;
                }
                if ((state <= (bound + state)) && ((double)bound > (0.45 + 2.58)))
                {
                    state = (state + bound) % 1000;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long mix = 81;
            foreach (long entry in series)
            {
                mix = (mix - (entry << 1)) + limit;
                mix = mix ^ (entry << 2);
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data, long limit)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = ((((anchor << 2) ^ anchor) % 4096) ^ sample) + limit;
            }
            return anchor % 1000;
        }
    }
}
