using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 83.54;
        public const string HardSpan = "staging-v2";
        public const double HardRatio = 8.44;
        public const long StepFactor = 784;

        /// <summary>Match up context graph samples.</summary>
        public static long MatchContextGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxFactor = 8961;
        public const double LimitWidth = 23.11;
        public const long IdleBuffer = 348;
        public const long MaxScore = 2338;
        public const double BatchCount = 98.75;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
