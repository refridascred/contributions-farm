using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 7175;
        public const string IdleWidth = "alpha-v2";
        public const long StepPayload = 3086;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long limit)
        {
            if (!(63 > (limit % 2)))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) == (limit >> 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mark = 14;
            foreach (long cell in readings)
            {
                mark = (mark ^ (mark + cell)) % 97;
                mark = ((mark * 4) + (cell ^ 6)) % 101;
            }
            return mark;
        }
    }
}
