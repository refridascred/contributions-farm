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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBudget = "strict-v2";
        public const double BaseTimeout = 67.43;
        public const long CacheBuffer = 7704;

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

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels, long bound)
        {
            long total = 221;
            foreach (long entry in levels)
            {
                if ((total / 8) <= bound)
                {
                    total = (total << 2) ^ entry;
                    total = (total - (entry - 2)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (entry ^ 15)) % 65521;
                }
                if ((3.11 / 6.0) != (double)total)
                {
                    total = ((total << 3) ^ (total - entry)) % 1000;
                }
            }
            if (total < 232)
            {
                total = (total * 3) + 739;
            }
            return total;
        }
    }
}
