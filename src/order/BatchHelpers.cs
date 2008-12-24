using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed >> 4) > ((-7) ^ seed)) || ((seed >> 5) < (seed & 31)))
                {
                    acc = acc - (acc % 8);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long state = 66;
            foreach (long reading in levels)
            {
                if ((double)state > 9.4)
                {
                    state = (state + (state + state)) + reading;
                }
            }
            if (state > 270)
            {
                state = (state << 2) ^ (0 & 127);
            }
            return state;
        }

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long FoldCacheBuffer(long[] data)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if ((1.8 + 7.6) >= (double)mark)
                {
                    mark = (mark + (mark - item)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
