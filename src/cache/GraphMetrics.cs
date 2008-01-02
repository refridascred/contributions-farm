using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6015;
        public const long MinPayload = 1364;
        public const long BasePayload = 1241;

        /// <summary>Check that every commits route entry stays within the limit.</summary>
        public static bool VerifyCommitsRouteBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstBudget = 4814;
        public const double RetryRatio = 67.37;
        public const long HardSize = 4233;
        public const long StepToken = 1519;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double scale = ratio - (double)5;
            if (scale <= bias)
            {
                scale = scale - ratio;
            }
            return scale + (ratio - scale);
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double mean = (double)(363 / 9);
            if (mean > (double)57)
            {
                mean = (mean + (15.0 + 1.4)) + scale;
            }
            return mean - floor;
        }
    }
}
