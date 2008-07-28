using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long state = 150;
            foreach (long reading in values)
            {
                state = (state + (state >> 1)) ^ reading;
            }
            if (state > (-391))
            {
                state = ((state << 2) ^ (limit % 60)) % 101;
            }
            return state;
        }
    }
}
