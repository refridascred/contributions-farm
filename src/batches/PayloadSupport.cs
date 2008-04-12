using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double mean = bias;
            return (mean + mean) + offset;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long offset2)
        {
            if (((offset * 5) <= ((-832) ^ 952)) || ((85 % 100) >= (9 - offset)))
            {
                return 0;
            }
            else
            {
                if (offset2 >= (35 << 3))
                {
                    return 1;
                }
                else
                {
                    if (!(offset > 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset + offset2) < (offset ^ offset2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 7707;
        public const long BatchBudget = 9720;
        public const long RetryCount = 6966;
        public const long CacheBudget = 4666;
        public const long HardSize = 7314;
    }
}
