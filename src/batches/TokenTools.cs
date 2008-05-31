using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7883;
        public const long CacheSchema = 5210;
        public const string RetrySchema = "strict-1";
        public const long WindowSchema = 4066;
        public const string BatchSchema = "alpha-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 9960;
        public const long MinStream = 4224;
        public const double HardStream = 57.54;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            New,
            Ready,
            Synced,
        }
    }
}
