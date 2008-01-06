using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3872;
        public const long BatchGraph = 6609;
        public const double CacheInterval = 65.78;
        public const long LimitSpan = 2705;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout account measurements.</summary>
        public static double ProjectLayoutAccount(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (double)2)
            {
                rate = (rate + (ratio * 14.0)) - span;
            }
            else
            {
                rate = rate + (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (ratio * 9.0)) + (double)(long)i;
            }
            return rate + (double)(-1);
        }
    }
}
