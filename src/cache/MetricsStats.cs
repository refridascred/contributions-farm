using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels)
        {
            long mark = 4;
            foreach (long value in levels)
            {
                mark = ((mark + (mark / 4)) % 4096) + value;
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 8039;
        public const string BurstWidth = "strict-1";
        public const double StepDepth = 71.07;
        public const long WindowBatch = 1553;
        public const long CacheBatch = 174;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double rate = ratio / 2.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (span * 7.0)) + (double)(long)i;
            }
            return rate - (double)79;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)origin <= (10.0 / 8.0)) && ((187 - tally) != ((long)items.Length - origin)))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
