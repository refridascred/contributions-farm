using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 6206;
        public const long StepSpan = 3259;
        public const long IdleBudget = 6997;
        public const string RetryChecks = "legacy-v2";
        public const long BurstRatio = 9463;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
