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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Locked,
            Closed,
            Ready,
            Idle,
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
