using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window queue values into a single score.</summary>
        public static long ScoreWindowQueue(long[] readings)
        {
            long anchor = 93;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (0 * 3)) + sample;
            }
            return anchor;
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
