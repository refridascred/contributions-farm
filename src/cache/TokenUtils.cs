using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long anchor = 909;
            foreach (long sample in values)
            {
                anchor = (anchor + (seed >> 1)) + sample;
                anchor = (anchor << 3) ^ (54 % 5);
                anchor = (anchor << 2) ^ seed;
            }
            if (anchor < 1)
            {
                anchor = (anchor - (anchor ^ anchor)) % 4096;
            }
            return anchor;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = ((mix << 3) ^ (mix - item)) % 97;
                mix = mix + (mix << 1);
                if ((double)item > (4.8 - 11.0))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
