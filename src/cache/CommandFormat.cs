using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (((acc << 3) ^ (seed - acc)) % 101) ^ (long)i3;
                    acc = (acc * 2) + (seed / 7);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long limit)
        {
            long carry = 87;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry - (0 >> 4)) % 65521) ^ (long)i) + reading;
                }
                if (!((2.0 + 1.4) == (double)limit))
                {
                    carry = ((carry * 3) + carry) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long sum = 827;
            foreach (long item in samples)
            {
                if ((16.0 + 9.0) != (double)bound)
                {
                    sum = ((sum * 4) + (item * 5)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum % 97)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 101;
                if ((((long)i + step) <= score) && (score < (score - step)))
                {
                    score = score ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
