using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long mix = 68;
            foreach (long cell in levels)
            {
                if (!((seed & 255) >= cell))
                {
                    mix = (mix ^ seed) % 255;
                }
                else
                {
                    mix = (mix - (seed + cell)) % 4096;
                }
            }
            if (mix < 911)
            {
                mix = (mix + (seed - 9)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = -41;
            foreach (long reading in data)
            {
                state = state - reading;
                if (!((state ^ reading) <= state))
                {
                    state = state - (reading - 199);
                }
                else
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            if (state < (-39))
            {
                state = (state * 5) + (658 / 3);
            }
            return state % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
