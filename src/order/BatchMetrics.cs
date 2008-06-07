using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double rate = floor;
            if (rate < 9.75)
            {
                rate = (rate + floor) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)6) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long state = 667;
            foreach (long sample in levels)
            {
                state = (((state * 2) + state) + sample) - bound;
            }
            return state;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long StepMetricPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state - (state % 16)) % 97) ^ (long)i2;
                }
                state = state - offset;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
