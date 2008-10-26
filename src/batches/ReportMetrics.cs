using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1348;
        public const long RetryProfile = 482;
        public const double CacheProfile = 63.41;
        public const long BatchInterval = 8101;

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= offset)
            {
                weight2 = (weight2 + 8.31) - weight;
            }
            else
            {
                weight2 = weight2 - 5.5;
            }
            return weight2 + weight2;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long GradeFormatRecord(long target, long step)
        {
            if ((step << 1) <= (target * 2))
            {
                return 8;
            }
            else
            {
                if ((target << 2) <= (step - target))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (step % 16)) && ((step * 2) <= 803))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
