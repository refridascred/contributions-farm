using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a order account figure with a bias.</summary>
        public static double BlendOrderAccount(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight / 9.0)) - (double)(long)i;
            }
            return load + (load - weight);
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (ratio * 2.0))
            {
                gain = (gain + (ratio / 9.0)) - offset;
            }
            else
            {
                gain = gain + (ratio / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long CombineMetricBatches(long[] data, long limit)
        {
            long sum = 9;
            foreach (long entry in data)
            {
                if (!(limit > (47 >> 2)))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum - (entry + limit)) % 101;
                }
                if ((sum & 31) < ((long)data.Length * 4))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
