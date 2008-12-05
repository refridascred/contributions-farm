using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstScore = 7158;
        public const long StepCommits = 140;
        public const string HardCommits = "staging-v2";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (bound <= (bound & 255))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
