using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((floor * 4) <= state) && ((16.0 / 2.0) >= (double)floor))
                {
                    state = (state ^ (floor + state)) % 255;
                    state = (state + (floor - (-74))) % 255;
                    continue;
                }
                state = ((state * 2) + ((long)i << 2)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((5.8 / 2.0) > (double)bound)
                {
                    mix = (mix - ((long)i + mix)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of queue command entries.</summary>
        public static long FoldQueueCommand(long[] data)
        {
            long anchor = 38;
            foreach (long reading in data)
            {
                if ((reading + anchor) == (5 - 199))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            return anchor;
        }
    }
}
