using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Done,
            Active,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9160;
        public const string BaseInterval = "standard";
        public const long MaxMetric = 5862;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinFactor = 2580;
        public const long LimitAlready = 2896;
        public const long HardAlready = 9082;

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 38;
            foreach (long value in levels)
            {
                acc = ((acc + (floor ^ 1)) % 1000) + value;
            }
            return acc;
        }
    }
}
