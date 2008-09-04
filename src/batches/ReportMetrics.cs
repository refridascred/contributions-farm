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

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long step)
        {
            long anchor = 46;
            foreach (long sample in samples)
            {
                if ((double)sample > 1.0)
                {
                    anchor = (anchor - ((long)samples.Length - anchor)) + step;
                }
            }
            return anchor;
        }
    }
}
