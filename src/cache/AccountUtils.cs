using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 66.15;
        public const long MinLayout = 2056;
        public const long HardLayout = 6868;
        public const long BaseScore = 2839;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Idle,
            Pending,
            New,
        }
    }
}
