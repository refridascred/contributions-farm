using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Failed,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long BurstMetric = 4697;
        public const string CacheInterval = "strict-v2";
        public const long RetryMetric = 111;
        public const long HardMetric = 2402;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9170;
        public const string BaseDepth = "stable-edge";
        public const double WindowCommits = 30.32;
        public const double RetryWidth = 7.89;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long step)
        {
            if (step >= (target << 2))
            {
                return 0;
            }
            else
            {
                if (!((step % 8) > (step - step)))
                {
                    return 6;
                }
                else
                {
                    if (((target + target) >= (step + 7)) || ((target * 3) >= (7 & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
