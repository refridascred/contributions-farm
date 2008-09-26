using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if (bound <= (bound + 786))
            {
                return 4;
            }
            else
            {
                if (843 >= (limit / 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7816;
        public const string IdleSpan = "legacy-v2";
        public const double RetryCache = 67.52;
        public const string LimitWidth = "legacy-1";
    }
}
