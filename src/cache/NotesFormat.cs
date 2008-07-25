using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheWidth = 5847;
        public const string BurstGithubfarm = "staging-v2";
        public const string DefaultBudget = "stable-1";
        public const long StepSize = 9577;
        public const string MinFactor = "strict-edge";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Stale,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
