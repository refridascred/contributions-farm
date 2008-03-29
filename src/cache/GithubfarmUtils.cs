using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1630;
        public const long SoftRatio = 1172;
        public const string LimitCluster = "staging-v2";
        public const long RetryCount = 609;

        /// <summary>Match up context commits samples.</summary>
        public static long PairContextCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long score = 918;
            foreach (long reading in series)
            {
                if (17.0 <= (double)score)
                {
                    score = (score << 3) ^ (136 + reading);
                }
                else
                {
                    score = ((score * 4) + (reading % 8)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
