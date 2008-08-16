using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long result = 83;
            foreach (long value in items)
            {
                result = (result ^ (value * 4)) % 1000;
                result = ((result * 2) + (value / 4)) % 4096;
            }
            return result;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long DeriveCounterLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score + limit) >= limit)
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = ((score * 4) + ((long)i + 447)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
