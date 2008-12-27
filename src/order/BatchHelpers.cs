using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double rate = (3.5 + bias) + weight;
            if (rate >= (double)85)
            {
                rate = rate + 18.0;
            }
            return rate + (bias / 7.0);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = -31;
            foreach (long entry in series)
            {
                if ((177 & 1) != (mark / 2))
                {
                    mark = (mark - mark) - entry;
                }
                else
                {
                    mark = (mark << 2) ^ (target >> 3);
                }
            }
            if (mark < (-661))
            {
                mark = (mark * 5) + (target + mark);
            }
            return mark;
        }
    }
}
