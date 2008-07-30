using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Paused,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
