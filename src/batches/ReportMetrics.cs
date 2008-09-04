using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 9332;
        public const long CacheTools = 6342;
        public const string BurstFactor = "local";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long target)
        {
            long score = 806;
            foreach (long datum in samples)
            {
                if (((target ^ datum) >= 6) && ((datum << 2) != (target ^ target)))
                {
                    score = ((score << 2) ^ target) % 255;
                }
                if ((score + score) == (score + target))
                {
                    break;
                }
            }
            return score;
        }
    }
}
