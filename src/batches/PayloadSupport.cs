using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - value) < (value * 3)) || !((410 << 3) == (matches + 361)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
