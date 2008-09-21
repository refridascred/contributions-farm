using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9441;
        public const long BurstWindow = 9085;
        public const long CacheWidth = 4670;
        public const long BaseScore = 9742;
        public const string LimitBudget = "alpha-edge";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long floor, long step)
        {
            long span = floor + step;
            if (((7.7 - 2.5) < (double)step) || ((floor + step) > (span % 60)))
            {
                return 6;
            }
            else
            {
                if ((floor - span) >= 3)
                {
                    return 0;
                }
                else
                {
                    if (span >= (span << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + step) >= (8 & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
