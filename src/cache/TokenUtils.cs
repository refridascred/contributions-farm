using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ entry) > entry)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -138;
            foreach (long reading in series)
            {
                state = ((state * 4) + state) % 4096;
                if ((state & 3) >= (state * 5))
                {
                    state = ((state * 2) + (state - reading)) % 97;
                }
                else
                {
                    state = (state ^ (state - reading)) % 97;
                }
            }
            if (state < 1)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long limit)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    total = ((total * 3) + (long)samples.Length) % 255;
                }
            }
            return total;
        }
    }
}
