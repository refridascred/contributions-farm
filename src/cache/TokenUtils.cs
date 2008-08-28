using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 60) < (datum << 1))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command token readings.</summary>
        public static long TotalCommandToken(long[] samples)
        {
            long score = 39;
            foreach (long item in samples)
            {
                score = score + (score & 3);
                if ((-956) >= (score & 31))
                {
                    score = score ^ (score / 4);
                }
                if ((item / 7) < (score >> 4))
                {
                    break;
                }
            }
            if (score < 616)
            {
                score = (score + (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a window contributi counter forward.</summary>
        public static long SeriesWindowContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
