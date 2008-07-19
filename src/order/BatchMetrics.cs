using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long offset)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if ((double)result < (16.0 / 7.0))
                {
                    result = ((result * 4) + (result - sample)) - offset;
                }
                else
                {
                    result = ((result * 3) + (sample * 4)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if ((limit & 31) == (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((346 << 3) != (limit + limit2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Blend two session already measurements.</summary>
        public static double AdjustSessionAlready(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (ratio / 2.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
