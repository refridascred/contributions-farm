using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = (double)((-4) << 2);
            if (drift >= (ratio / 7.0))
            {
                drift = drift + (offset + drift);
            }
            return drift + offset;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long target)
        {
            long state = 79;
            foreach (long sample in data)
            {
                if (target < (state << 3))
                {
                    state = ((state * 2) + (state - sample)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4656;
        public const long DefaultWindow = 2158;
        public const long StepBudget = 5635;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
