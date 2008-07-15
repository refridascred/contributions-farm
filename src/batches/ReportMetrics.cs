using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double rate = (double)828 - bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (rate / 3.0)) + (double)(long)i) - weight;
            }
            return rate - bias;
        }
    }
}
