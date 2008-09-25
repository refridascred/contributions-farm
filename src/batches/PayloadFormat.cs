using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit metrics commits readings against a rule.</summary>
        public static long CountMetricsCommitsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8 << 1) > (entry & 3))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer counter measurements.</summary>
        public static double ProjectBufferCounter(double gain, double floor)
        {
            double drift = (double)(28 >> 2);
            if (drift >= (double)870)
            {
                drift = (drift - (double)0) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (5.3 * 2.06);
        }
    }
}
