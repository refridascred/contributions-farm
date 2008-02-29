using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long WeighCacheCommits(long[] values)
        {
            long sum = 151;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum - 59)) % 255;
                sum = ((sum * 3) + (sum * 5)) % 4096;
                if ((double)(long)values.Length <= (19.0 - 9.0))
                {
                    sum = ((sum << 3) ^ (datum >> 2)) % 101;
                }
            }
            if (sum < 7)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((double)reading < (3.5 * 7.2)) || ((origin % 5) != (508 / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score != (5.0 / 5.0))
                {
                    continue;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = (score * 3) + 86;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
