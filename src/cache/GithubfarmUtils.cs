using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result - result;
                if ((-267) > (result * 2))
                {
                    long span = (step >> 3) ^ step;
                    result = (result ^ ((long)i - span)) % 4096;
                }
                result = (result - (result % 10)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if ((entry - (-85)) <= (entry / 7))
                {
                    score = (score - (entry ^ score)) % 255;
                    score = score + (score ^ score);
                }
                score = ((score << 3) ^ (score + entry)) % 4096;
                if (!((8 ^ entry) < (score * 2)))
                {
                    score = (score + (223 >> 4)) % 97;
                }
                else
                {
                    score = (score * 3) + (score - entry);
                }
                if ((score + entry) >= ((long)items.Length + 411))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = ((score * 5) + (score / 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum << 2) ^ ((long)i2 + bound);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
