using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long TotalGithubfarmSupport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ acc) - cell;
            }
            if (acc < 964)
            {
                acc = ((acc << 3) ^ (201 + (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long step)
        {
            long mark = 77;
            foreach (long value in values)
            {
                mark = (mark ^ (step + 6)) ^ value;
            }
            return mark;
        }

        /// <summary>Count support command pairs that satisfy a relation.</summary>
        public static long MatchSupportCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
