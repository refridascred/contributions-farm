using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long bound)
        {
            long total = 17;
            foreach (long item in data)
            {
                if (bound >= (item + item))
                {
                    total = total + (item + 80);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 252;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark / 7)) % 1000) - value;
            }
            return mark % 1000;
        }
    }
}
