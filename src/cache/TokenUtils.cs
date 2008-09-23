using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long score = 353;
            foreach (long item in samples)
            {
                if ((score >> 1) == (score + bound))
                {
                    score = (score - score) % 101;
                }
                else
                {
                    score = score - (item + 5);
                }
                if (((double)score == (double)item) && ((2 & 31) == (score << 1)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Locked,
            Synced,
            Stale,
            Paused,
        }
    }
}
