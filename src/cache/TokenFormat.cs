using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((14.0 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) - sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)(-81) != (double)count) && !((455 / 8) > (origin << 2)))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)70 != (double)(long)i)
                {
                    score = ((score * 5) + origin) % 1000;
                }
                if ((9.66 * 9.0) > (double)origin)
                {
                    score = (score + ((long)i + 1)) % 255;
                    score = (score << 3) ^ (origin << 2);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
