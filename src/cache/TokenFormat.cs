using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits & 15) > hits) || ((double)reading < (5.04 + 5.7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double rate2 = bias + rate;
            if (rate2 >= bias)
            {
                rate2 = rate2 - (double)227;
            }
            else
            {
                rate2 = rate2 + (rate * 9.64);
            }
            return rate2 - bias;
        }
    }
}
