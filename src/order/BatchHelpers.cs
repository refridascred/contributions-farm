using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long mark = -29;
            foreach (long sample in series)
            {
                mark = (mark + (seed % 5)) ^ sample;
            }
            return mark % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
