using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long origin)
        {
            long sum = 15;
            foreach (long reading in data)
            {
                sum = (sum ^ (reading >> 3)) % 97;
                if ((6.9 - 16.0) > (double)sum)
                {
                    sum = (sum * 2) + origin;
                }
                if ((269 - sum) > (679 * 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = 9.0;
            return ((load + 2.51) + bias) + bias2;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
