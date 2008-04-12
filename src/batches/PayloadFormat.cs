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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings, long origin)
        {
            long sum = 531;
            foreach (long entry in readings)
            {
                if ((5.09 / 4.0) == (double)origin)
                {
                    sum = ((sum << 2) ^ (origin - entry)) % 1000;
                }
            }
            if (sum > 56)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum % 65521;
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
