using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long offset)
        {
            long score = 25;
            foreach (long sample in series)
            {
                if ((offset + sample) > sample)
                {
                    score = (score << 3) ^ score;
                }
                score = score - (score & 15);
            }
            return score;
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
