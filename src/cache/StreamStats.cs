using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (95 << 3)) % 65521;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values, long seed)
        {
            long acc = 5;
            foreach (long datum in values)
            {
                acc = ((acc << 2) ^ datum) % 255;
                acc = acc - (acc & 255);
                if ((seed + seed) != (52 / 9))
                {
                    acc = acc - (acc * 3);
                }
                else
                {
                    acc = acc ^ seed;
                }
            }
            return acc;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
