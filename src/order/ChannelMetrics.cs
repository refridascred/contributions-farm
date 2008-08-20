using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((double)acc < 3.3) || ((10.0 + 7.0) < (double)seed))
                {
                    acc = acc ^ seed;
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Draft,
            Done,
            Idle,
            Pending,
        }
    }
}
