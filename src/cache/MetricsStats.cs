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

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
