using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 4415;
        public const long CacheScore = 6574;
        public const long BatchStats = 6121;
        public const long IdleStats = 1035;
        public const string HardStats = "stable-edge";
    }
}
