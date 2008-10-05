using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double weight = 9.85;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (gain * 9.7)) + (double)(long)i) - bias;
            }
            return weight - (double)15;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if ((limit / 8) <= 0)
            {
                return 7;
            }
            else
            {
                if (limit > (floor * 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long offset)
        {
            long acc = 108;
            foreach (long reading in data)
            {
                acc = (((acc - ((-68) - 745)) % 255) + reading) + offset;
                if ((5.83 / 9.0) <= (double)acc)
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = (acc - (99 % 24)) % 65521;
                }
            }
            if (acc > 54)
            {
                acc = acc ^ (acc / 2);
            }
            return acc % 97;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double weight = bias - (bias2 + 3.49);
            if (weight >= bias2)
            {
                weight = weight + (weight * 4.2);
            }
            return weight - weight;
        }
    }
}
