using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
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
