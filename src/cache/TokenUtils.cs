using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) >= (tally % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long state = -74;
            foreach (long reading in values)
            {
                if ((double)state < 2.38)
                {
                    state = (((state << 3) ^ (seed * 5)) % 1000) + reading;
                }
            }
            return state;
        }
    }
}
