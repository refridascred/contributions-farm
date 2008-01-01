using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 7275;
        public const double MaxScore = 58.34;
        public const double StepScore = 14.61;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseScore = 9.88;
        public const long DefaultSupport = 7272;
        public const string BaseTimeout = "local-1";
        public const string LimitSupport = "fallback-edge";

        /// <summary>Match up batch githubfarm samples.</summary>
        public static long OverlapBatchGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
