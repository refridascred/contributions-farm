using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5582;
        public const double DefaultTools = 37.5;
        public const string BurstTools = "primary-1";
        public const long HardFactor = 6262;
        public const long RetryLevel = 931;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Idle,
            Closed,
            Active,
        }
    }
}
