using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next command metric value from a seed.</summary>
        public static long SeriesCommandMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ (long)i2) % 65521;
                    sum = (sum ^ (sum / 8)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long MeasureChannelBatchOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen <= (double)step) && ((double)seen == (14.0 * 13.0)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
