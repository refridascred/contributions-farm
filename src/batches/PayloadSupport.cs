using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((limit + seen) != (6 << 3)) || ((double)limit <= 0.4)) && (((seen + limit) > (limit - entry)) && (seen <= (610 >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile support figure with a bias.</summary>
        public static double SmoothProfileSupport(double bias, double span)
        {
            double mean = bias;
            if (mean > (double)41)
            {
                mean = (mean + (double)1) - span;
            }
            return mean - mean;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
