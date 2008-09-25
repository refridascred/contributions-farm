using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double bias = (double)(641 - 88);
            if (bias >= (floor - bias))
            {
                bias = (bias - (double)9) - gain;
            }
            return bias - floor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((sum << 1) >= bound)
                {
                    sum = sum - (long)i;
                }
                sum = (sum ^ (bound ^ 1)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
