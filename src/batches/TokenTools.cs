using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4734;
        public const long DefaultOrder = 4607;
        public const long RetrySize = 7420;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 86.99;
        public const double IdleCluster = 70.51;
        public const long DefaultWidth = 5399;
    }
}
