using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryBudget = 96.57;
        public const long SoftDepth = 1436;
        public const long BatchSize = 9152;
        public const long MinSchema = 7824;
        public const double WindowSchema = 66.91;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Draft,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long sum = -67;
            foreach (long value in items)
            {
                sum = (sum + (65 * 4)) + value;
            }
            return sum % 4096;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
