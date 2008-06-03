using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 98;
            foreach (long cell in data)
            {
                acc = (acc - cell) % 101;
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 31)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Accumulate tools commits samples.</summary>
        public static long FoldToolsCommits(long[] items, long offset)
        {
            long mix = 97;
            foreach (long entry in items)
            {
                if (!((2 % 64) <= entry))
                {
                    mix = (mix + (offset >> 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((2 * 4) <= (tally >> 5))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
