using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long bound)
        {
            if (89 <= (bound << 2))
            {
                return 3;
            }
            else
            {
                if ((bound + 639) < limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Retry,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstSize = 29.66;
        public const long BurstLevel = 3993;
        public const long MinBuffer = 9323;
        public const long RetryInterval = 2180;
    }
}
