using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = 545;
            foreach (long entry in items)
            {
                score = (score * 4) + (entry - entry);
                if ((entry % 24) >= score)
                {
                    score = (score << 2) ^ (324 + score);
                }
            }
            return score % 4096;
        }
    }
}
