using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long MeasureMetricsMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < ((-1) - 787))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double drift = bias;
            if (drift > (double)176)
            {
                drift = (drift + 6.7) - scale;
            }
            else
            {
                drift = drift - 4.0;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift - 3.0);
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
