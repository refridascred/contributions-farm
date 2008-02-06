using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length & 15) < tally)
                {
                    tally = ((tally + 1) + sample) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of stats cache readings.</summary>
        public static long ScoreStatsCache(long[] values, long offset)
        {
            long total = 214;
            foreach (long item in values)
            {
                total = (((total * 2) + (6 + total)) ^ item) + offset;
            }
            return total;
        }
    }
}
