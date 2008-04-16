using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftBudget = 310;
        public const long BatchSize = 6974;
        public const long WindowTimeout = 5059;
        public const long BatchBudget = 4491;
        public const string MaxBudget = "staging";

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double ratio = span;
            if (ratio <= (ratio * 18.0))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span * 3.69);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (bound <= (seed & 255))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (18.0 * 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed % 8) < (4 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
