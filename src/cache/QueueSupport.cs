using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a buffer command reading.</summary>
        public static double ProjectBufferCommand(double ratio, double bias)
        {
            double weight = 7.9;
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight - (double)765) + (double)(long)i) + ratio) + bias;
            }
            return weight - (double)79;
        }

        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long LookupContextFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double mean = 7.2;
            if (mean > (bias - bias))
            {
                mean = mean + (double)476;
            }
            else
            {
                mean = mean + (2.7 * 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - (floor - bias);
        }
    }
}
