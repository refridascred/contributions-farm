using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = span * 6.37;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (9.63 - 4.97)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Retry,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 727;
        public const long MinFactor = 3893;
        public const string RetryProfile = "standard-edge";
        public const double StepRatio = 70.69;
    }
}
