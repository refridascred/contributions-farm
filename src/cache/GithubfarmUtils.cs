using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 3) ^ offset) - (long)i2;
                }
                state = state + offset;
                state = state ^ state;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)bound >= (5.26 * 2.6))
                {
                    total = (total ^ (1 + bound)) % 65521;
                }
                total = total ^ (total ^ (long)i);
                total = ((total * 3) + bound) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings, long step)
        {
            long anchor = 92;
            foreach (long cell in readings)
            {
                if ((anchor + anchor) == (step % 24))
                {
                    anchor = (((anchor * 4) + (18 << 1)) % 101) ^ cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] values)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if ((score + score) >= (datum + datum))
                {
                    score = ((score * 4) + (datum + datum)) % 1000;
                }
                else
                {
                    score = score ^ (48 + score);
                }
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 65521;
        }
    }
}
