using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 90.45;
        public const long DefaultFormat = 6305;
        public const long IdleCount = 5974;
        public const long IdleFormat = 8498;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Paused,
            Synced,
        }
    }
}
