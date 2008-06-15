using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry + 6) >= (origin ^ 0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer profile reading by value.</summary>
        public static long FindBufferProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long acc = 107;
            foreach (long item in values)
            {
                acc = (((acc * 3) + (bound % 7)) % 65521) ^ item;
                acc = ((acc * 3) + acc) % 4096;
            }
            return acc % 65521;
        }
    }
}
