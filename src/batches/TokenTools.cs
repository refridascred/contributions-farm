using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long StepBatchesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((state & 1) < limit) && ((double)state == (4.0 / 7.0)))
                {
                    state = (state + (limit & 15)) % 65521;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - (limit & 3)) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7603;
        public const string HardTimeout = "standard-1";
        public const long LimitCounter = 2119;
    }
}
