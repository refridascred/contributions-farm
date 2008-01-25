using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "alpha";
        public const string IdleDepth = "stable-v2";
        public const string BurstContributi = "stable-v2";
        public const long MinDepth = 9697;

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 65.08;
        public const long StepScore = 6666;
        public const string IdleCommits = "open-edge";
        public const long StepBudget = 4989;
    }
}
