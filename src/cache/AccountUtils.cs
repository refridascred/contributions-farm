using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 3195;
        public const long WindowLayout = 9820;
        public const string RetryLayout = "alpha-edge";
        public const long MinSpan = 1812;
        public const long BaseLayout = 3889;

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double bias2 = bias + (double)8;
            if (bias2 >= 5.0)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - (double)3;
        }
    }
}
