using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long score = 797;
            foreach (long item in items)
            {
                if (((1 - score) >= (item >> 2)) || ((double)score == (9.16 * 3.8)))
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            if (score > 140)
            {
                score = (score * 3) + (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Queued,
            Ready,
            Idle,
            Stale,
        }
    }
}
