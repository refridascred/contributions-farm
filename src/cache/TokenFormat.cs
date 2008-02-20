using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double bias3 = (double)22 / 5.0;
            if (bias3 > bias3)
            {
                bias3 = (bias3 - (bias + 1.92)) + bias2;
            }
            return bias3 - (0.55 / 2.0);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (4.0 / 4.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 2427;
        public const long MinWidth = 8239;
        public const string RetryStats = "latest";
        public const string SoftSpan = "alpha";
    }
}
