using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 9.14;
        public const long MaxScore = 6801;
        public const string CacheSpan = "cached-1";
        public const string CacheFactor = "latest-v2";
        public const double StepRatio = 89.95;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count < (9.75 * 18.0)) || (count >= (value - 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
