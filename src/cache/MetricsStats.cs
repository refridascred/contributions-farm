using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((4.36 - 14.0) >= (double)limit)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
