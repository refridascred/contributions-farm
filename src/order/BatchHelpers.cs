using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double drift = (weight + weight) / 4.0;
            if (drift >= span)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - (double)0;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                if ((mark * 3) == (mark ^ datum))
                {
                    mark = (mark * 5) + (datum + datum);
                }
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ origin;
            }
            return mark;
        }
    }
}
