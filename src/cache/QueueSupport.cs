using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double bias3 = bias2 / 7.0;
            if (bias3 > (double)8)
            {
                bias3 = (bias3 + (double)4) + bias;
            }
            return bias3 + bias2;
        }

        /// <summary>Grade a buffer cluster value against two limits.</summary>
        public static long ClassifyBufferCluster(long limit, long bound)
        {
            if ((537 % 8) < (bound % 60))
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) == (bound - limit))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
