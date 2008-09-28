using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mark = 511;
            foreach (long cell in samples)
            {
                mark = (mark + (mark ^ cell)) % 101;
                if (4.91 < (double)mark)
                {
                    mark = (mark + (cell + mark)) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
        }
    }
}
