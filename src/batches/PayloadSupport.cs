using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 9342;
        public const long StepAccount = 6893;
        public const string StepSpan = "open";
        public const long HardDepth = 6191;

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double floor)
        {
            double weight = (double)(935 - (-68));
            if (weight <= (bias + bias))
            {
                weight = weight - (bias - bias);
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (10.0 + 7.77)) + (double)(long)i;
            }
            return weight + (floor + floor);
        }
    }
}
