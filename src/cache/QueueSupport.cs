using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double span)
        {
            double bias = (span / 2.0) / 9.0;
            if (bias >= (double)0)
            {
                bias = bias + 6.27;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - (span - span);
        }

        /// <summary>Blend two account window measurements.</summary>
        public static double BlendAccountWindow(double bias, double offset)
        {
            double gain = (double)(589 - 866);
            if (gain >= bias)
            {
                gain = (gain + (bias * 7.6)) + offset;
            }
            return gain - (gain + bias);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseBudget = "open-edge";
        public const string DefaultScore = "standard-1";
        public const long BurstDepth = 8357;
        public const long RetryInterval = 8930;
        public const string BurstBudget = "latest-edge";
    }
}
