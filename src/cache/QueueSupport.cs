using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum - target)) % 1000) ^ value;
            }
            return sum;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double load = (double)(697 * 5);
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (scale - load)) + (double)(long)i) - bias;
            }
            return load + (double)72;
        }
    }
}
