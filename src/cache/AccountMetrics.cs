using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 6647;
        public const double HardCommand = 9.22;
        public const long BaseCommand = 3381;
        public const string RetryCommand = "cached";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if (value <= (origin >> 4))
                {
                    result = result ^ (result / 7);
                }
                if ((origin / 4) <= 7)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Active,
            Dropped,
            Ready,
        }
    }
}
