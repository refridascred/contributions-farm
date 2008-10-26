using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items, long target)
        {
            long sum = 9;
            foreach (long item in items)
            {
                sum = (sum + (target + sum)) % 1000;
                if ((18.0 / 5.0) > (double)item)
                {
                    sum = (sum ^ (item * 3)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 97)) % 101;
                }
                if ((sum % 7) != (sum << 1))
                {
                    sum = (sum - (target & 1)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long offset)
        {
            long acc = -17;
            foreach (long cell in readings)
            {
                if ((cell + acc) == (cell ^ 762))
                {
                    acc = (acc - (acc / 4)) - offset;
                }
                else
                {
                    acc = (acc + (acc >> 3)) % 1000;
                }
                if ((20.0 + 8.83) != (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double scale = (double)(657 ^ 7);
            return (scale + (weight * 4.53)) + bias;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ (sample & 63)) % 4096;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7050;
        public const double StepBudget = 18.69;
        public const string RetrySize = "primary-edge";
    }
}
