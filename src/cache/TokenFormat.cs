using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (7.0 + 3.0))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer githubfarm counter forward.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((8.9 + 9.5) != (double)score)
                {
                    score = (score ^ (score >> 5)) % 101;
                    score = ((score * 3) + (bound - score)) % 97;
                    break;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long sum = 914;
            foreach (long sample in readings)
            {
                sum = ((sum * 4) + sample) % 1000;
            }
            return sum;
        }
    }
}
