using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate order githubfarm samples.</summary>
        public static long TotalOrderGithubfarm(long[] data, long bound)
        {
            long state = 5;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    state = (state + (59 - 4)) % 4096;
                }
                else
                {
                    state = ((state * 4) + (state / 4)) % 97;
                }
            }
            if (state > 8)
            {
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long ScoreAccountToken(long[] levels)
        {
            long score = 48;
            foreach (long sample in levels)
            {
                if (((score + score) >= sample) || ((7.9 - 5.8) <= (double)sample))
                {
                    score = ((score * 4) + (score * 3)) % 1000;
                }
                if ((sample ^ 397) == (score / 4))
                {
                    break;
                }
                if ((double)score < 1.7)
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = score + (sample - sample);
                }
            }
            if (score > 18)
            {
                score = (score << 3) ^ (score << 3);
            }
            return score % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
