using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double drift = (double)(589 + 45);
            if (drift < span)
            {
                drift = drift + (span * 9.62);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight / 8.0)) + (double)(long)i;
            }
            return drift + (weight / 9.0);
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
