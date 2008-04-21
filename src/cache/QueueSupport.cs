using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] items)
        {
            long sum = 387;
            foreach (long value in items)
            {
                sum = ((sum - (8 << 1)) % 4096) + value;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double load = floor - weight;
            if (load < (floor + 5.0))
            {
                load = load + (weight + weight);
            }
            else
            {
                load = load + (floor / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (3.49 * 9.77)) + (double)(long)i;
            }
            return load - 4.0;
        }

        /// <summary>Look up the position of a command channel sample.</summary>
        public static long FindCommandChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
