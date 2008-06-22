using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (bias / 6.0))
            {
                mean = mean - (bias * 4.99);
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (double)8;
        }

        /// <summary>Match up account route samples.</summary>
        public static long PairAccountRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
