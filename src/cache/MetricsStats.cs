using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit >> 1) != (limit / 7))
                {
                    state = (state * 3) + state;
                    break;
                }
                else
                {
                    state = state + (limit >> 4);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ mix) % 255;
                if ((19.0 * 7.24) < (double)offset)
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix - mix) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Failed,
            Active,
            Pending,
        }
    }
}
