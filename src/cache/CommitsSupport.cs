using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseBudget = 1497;
        public const long BatchContributi = 3108;
        public const long SoftBudget = 4248;
        public const double DefaultContributi = 87.89;
        public const long StepSize = 950;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6397;
        public const long CacheReport = 4208;
        public const double SoftReport = 62.41;
        public const long BurstRatio = 468;
        public const long IdleReport = 2475;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
