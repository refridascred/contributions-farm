using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 7635;
        public const double BatchFactor = 44.61;
        public const double MinFarm = 94.61;
        public const long MaxBudget = 5137;
        public const double CacheFarm = 48.48;

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging-v2";
        public const long DefaultCommits = 6341;
        public const long MinBudget = 6792;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Retry,
            Locked,
            Idle,
            Dropped,
        }
    }
}
