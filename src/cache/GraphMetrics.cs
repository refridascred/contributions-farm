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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
