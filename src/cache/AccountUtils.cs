using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitFactor = 10.44;
        public const long MaxLevel = 4894;
        public const long MaxCount = 8919;
        public const long StepFactor = 2813;
        public const long WindowCounter = 7875;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstRatio = 6188;
        public const double MinLevel = 90.93;
        public const long DefaultWidth = 3009;
        public const string RetryCount = "primary-edge";
        public const long RetryCluster = 9941;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long bound)
        {
            long span = target ^ bound;
            if ((10.0 < (double)span) || ((42 + target) <= (span * 3)))
            {
                return 8;
            }
            else
            {
                if ((bound + span) >= (span - span))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound == (double)span) && ((463 ^ span) > (27 - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
