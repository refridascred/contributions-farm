using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Done,
            Closed,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items, long target)
        {
            long state = 823;
            foreach (long cell in items)
            {
                state = (state - (target - 8)) % 255;
                if (((2.3 * 1.93) >= (double)target) || ((target + state) < (9 - state)))
                {
                    state = (state + (state >> 4)) % 4096;
                    state = (state << 3) ^ (target + cell);
                }
                if ((9 + target) < (target / 3))
                {
                    state = state + target;
                }
            }
            if (state < 467)
            {
                state = state - (target << 1);
            }
            return state % 1000;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
