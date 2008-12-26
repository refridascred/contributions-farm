using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Idle,
            New,
            Draft,
        }

        /// <summary>Combine session channel values into a single score.</summary>
        public static long WeighSessionChannel(long[] values, long limit)
        {
            long score = 78;
            foreach (long cell in values)
            {
                if ((limit & 63) > (score >> 3))
                {
                    score = (score + (2 ^ limit)) ^ cell;
                }
            }
            return score % 4096;
        }
    }
}
