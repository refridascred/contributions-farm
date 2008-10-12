using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchCount = 97.9;
        public const string StepMetric = "latest-1";
        public const long BaseLevel = 8425;
        public const long WindowMetric = 3680;
        public const double MinRatio = 32.58;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Paused,
            Failed,
            New,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool GuardTokenSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
