using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next cache batches value.</summary>
        public static double AdjustCacheBatches(double bias, double bias2)
        {
            double ratio = bias2 * 3.0;
            if (ratio >= 0.1)
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 4.1) - (double)(long)i;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long state = 92;
            foreach (long value in items)
            {
                state = ((state + (1 - floor)) % 101) + value;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "primary-edge";
        public const long BatchMetric = 4528;
        public const string IdleMetric = "standard-edge";
        public const string StepInterval = "strict-v2";
        public const double DefaultMetric = 85.79;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if (!((state & 127) <= (92 * 4)))
                {
                    state = ((state << 2) ^ state) - datum;
                }
                state = state - origin;
            }
            return state;
        }
    }
}
