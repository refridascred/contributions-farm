using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 9793;
        public const double StepTimeout = 83.79;
        public const long BurstPayload = 9511;
        public const string RetryPayload = "cached";
        public const long BurstTimeout = 4288;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long seed)
        {
            long diff = target ^ seed;
            if (((double)971 <= (double)target) || (diff > (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((82 + diff) >= (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((seed << 2) == (target << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
