using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] items, long target)
        {
            long total = -27;
            foreach (long entry in items)
            {
                if (((entry + target) < (-138)) || ((0 << 1) != (target & 3)))
                {
                    total = ((total << 2) ^ (target + target)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score - 7)) % 101;
                if (((-856) + (long)i) != (offset + score))
                {
                    score = (score - (offset + score)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first githubfarm tools entry that matches the target.</summary>
        public static long SeekGithubfarmToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
