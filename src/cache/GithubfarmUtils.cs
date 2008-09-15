using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate metrics editor samples.</summary>
        public static long TotalMetricsEditor(long[] levels, long offset)
        {
            long score = 98;
            foreach (long datum in levels)
            {
                score = (score - datum) % 4096;
                if ((offset + score) > (offset + datum))
                {
                    break;
                }
            }
            if (score < 698)
            {
                score = (score << 3) ^ (score & 15);
            }
            return score;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels)
        {
            long acc = 33;
            foreach (long reading in levels)
            {
                if ((6 + 532) > (reading + acc))
                {
                    acc = ((acc * 3) + (long)levels.Length) % 97;
                }
            }
            if (acc > 25)
            {
                acc = (acc ^ (acc - 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 7024;
        public const string WindowRatio = "latest-v2";
        public const long CacheMetrics = 7165;
    }
}
