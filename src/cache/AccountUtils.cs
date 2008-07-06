using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 2262;
        public const long StepCluster = 6404;
        public const long BurstCluster = 7719;
        public const string SoftCluster = "primary-edge";
        public const long LimitCluster = 4723;

        /// <summary>Project the next batches order value.</summary>
        public static double ScaleBatchesOrder(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (scale + ratio))
            {
                ratio = ratio + 19.0;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + (double)717;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double mean = floor;
            if (mean >= (double)7)
            {
                mean = mean - 16.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (9.8 / 7.0)) + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
