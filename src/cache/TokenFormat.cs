using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long score = 330;
            foreach (long entry in series)
            {
                if (929 >= (long)series.Length)
                {
                    score = ((score - (422 * 3)) ^ entry) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long DigestGithubfarmContext(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (963 + 23)) - item;
            }
            if (sum < 59)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
