using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8983;
        public const double MinInterval = 33.57;
        public const long RetryFactor = 7897;
        public const long HardDepth = 5733;
        public const string DefaultReport = "legacy-edge";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long LookupStreamMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Project the next profile schema value.</summary>
        public static double ScaleProfileSchema(double bias, double floor)
        {
            double rate = floor - floor;
            if (rate < 5.38)
            {
                rate = rate - (bias + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (7.4 - bias)) + (double)(long)i;
            }
            return rate - (rate + floor);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
