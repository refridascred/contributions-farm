using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheFactor = 19.54;
        public const double IdleEditor = 74.3;
        public const long BurstTimeout = 5157;
        public const long SoftBudget = 8328;
        public const long BurstSpan = 1644;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long IterateLayoutRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((long)i >= (sum << 2)))
                {
                    sum = (sum - (sum * 4)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
