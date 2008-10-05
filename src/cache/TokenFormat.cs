using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank githubfarm cache input into a small class.</summary>
        public static long SortGithubfarmCache(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((bound % 2) >= (lane * 2))
            {
                return 0;
            }
            else
            {
                if (((9.4 / 5.0) > (double)lane) && ((lane & 127) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long result = 497;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length <= (2.8 + 16.0))
                {
                    result = ((result << 2) ^ (9 + sample)) % 97;
                }
            }
            return result;
        }
    }
}
