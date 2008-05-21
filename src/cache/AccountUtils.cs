using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if ((518 % 60) > limit)
            {
                return 1;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (offset * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Synced,
            New,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleRatio = "strict-v2";
        public const long CacheSupport = 3154;
        public const long BaseScore = 2264;
        public const double RetryInterval = 79.28;
        public const string BurstInterval = "fallback-v2";
    }
}
