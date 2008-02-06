using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 0.46)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
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
